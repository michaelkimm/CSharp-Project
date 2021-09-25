using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdventureGame
{
    class Player : GameUnit
    {
        Weapon equipments;
        List<Item> inventory;

        public Player(PictureBox pictureBox, Label label, Point pose, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, pose, speed, initialHitPoint, initialMp, power, detectLength)
        {
            inventory = new List<Item>();
        }

        public Player(PictureBox pictureBox, Label label, int x, int y, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, x, y, speed, initialHitPoint, initialMp, power, detectLength)
        {
            inventory = new List<Item>();
        }

        public override bool Detected(GameUnit gameUnit, EnumClass.MoveDir dir)
        {
            bool result = false;

            if (!(gameUnit is Enemy))
                return false;

            Enemy enemy = gameUnit as Enemy;
            if ((enemy.Pose.X - this.Pose.X) * (enemy.Pose.X - this.Pose.X) + (enemy.Pose.Y - this.Pose.Y) * (enemy.Pose.Y - this.Pose.Y) <= detectLength * detectLength)
                result = true;
            else
                return false;


            switch (dir)
            {
                case EnumClass.MoveDir.Left:
                    if (!((this.Pose.X - enemy.Pose.X) >= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Up:
                    if (!((this.Pose.Y - enemy.Pose.Y) >= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Right:
                    if (!((this.Pose.X - enemy.Pose.X) <= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Down:
                    if (!((this.Pose.Y - enemy.Pose.Y) <= 0))
                    {
                        result = false;
                    }
                    break;
                default:
                    break;
            }

            return result;
        }

        public override void Attack(GameUnit gameUnit)
        {
            if (!(gameUnit is Enemy))
                return;

            if (IsDead) return;
            if (gameUnit.IsDead) return;

            // 적을 무기로 공격한다
            Enemy enemy = gameUnit as Enemy;
            equipments.Attack(enemy, Power);
        }

        public Item FindCollision(List<Item> items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if ((items[i].Pose.X - this.Pose.X) * (items[i].Pose.X - this.Pose.X) + (items[i].Pose.Y - this.Pose.Y) * (items[i].Pose.Y - this.Pose.Y) <= 10 * 10)
                    return items[i];
            }
            return null;
        }

        public void GetItem(Item item)
        {
            // 인게임 아이템 비활성화
            item.ActiveIngame(false);

            item.ActiveInventory(true);
            inventory.Add(item);
            RefreshInventory();
        }
        private void RefreshInventory()
        {
            // 80 322 + 56
            for (int i = 0; i < inventory.Count; i++)
            {
                inventory[i].Pose = new Point(80 + i * 56, 322);
            }
        }

        public void Equip(String weaponName)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (!(inventory[i] is Weapon))
                    continue;

                Weapon weapon = inventory[i] as Weapon;
                if (!(weapon.Name.Equals(weaponName)))
                    continue;

                if (equipments != null)
                {
                    // 이전 장착된 것 해제
                    equipments.PbInventoryItem.BorderStyle = BorderStyle.None;
                }

                // 새로 장착
                equipments = weapon;
                equipments.PbInventoryItem.BorderStyle = BorderStyle.FixedSingle;
                break;
            }
        }
        public void Use(string consumableItem)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (!(inventory[i] is Potion))
                    continue;

                Potion potion = inventory[i] as Potion;
                if (!(potion.Name.Equals(consumableItem)))
                    continue;

                potion.Use(this);

                // 인벤토리에서 제거
                inventory.RemoveAt(i);

                // 인벤토리 재정리
                RefreshInventory();
                break;
            }
        }
    }
}
