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
        Weapon equipments = null;
        List<Item> inventory;

        public Player(Game game, PictureBox pictureBox, Label label, Point pose, PlayerCharacterInfo characterInfo)
            : base(game, pictureBox, label, pose, characterInfo)
        {
            inventory = new List<Item>();
        }

        public Player(Game game, PictureBox pictureBox, Label label, int x, int y, PlayerCharacterInfo characterInfo)
            : base(game, pictureBox, label, x, y, characterInfo)
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

        public override void Attack(EnumClass.MoveDir dir)
        {
            if (IsDead)
                return;

            if (equipments == null)
            {
                MessageBox.Show("Need Weapon!");
                return;
            }

            // 적을 무기로 공격한다
            equipments.Attack(dir, this.Power);
        }

        public override void Move(EnumClass.MoveDir dir)
        {
            // 움직인 후
            base.Move(dir);

            // 플레이어는 아이템을 먹을 수 있다.
            for (int i = 0; i < game.inGameItems.Count; i++)
            {
                GameObject foundItem = CollisionWith(game.inGameItems[i]);
                if (foundItem != null)
                {
                    Item item = foundItem as Item;
                    MessageBox.Show("Found Item");
                    GetItem(item);
                    game.inGameItems.Remove(item);
                }
            }
            
            
        }

        public void GetItem(Item itemObj)
        {
            // 인게임 아이템 비활성화
            itemObj.ActivePicture(false);

            // 인벤토리에 넣을 아이템 생성
            Item item = game.CreateItem(itemObj.Name);

            // 인벤토리에 아이템 삽입
            inventory.Add(item);

            // 인벤토리 위치 초기화
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

        public void Equip(WeaponType weaponType)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                if (!(inventory[i] is Weapon))
                    continue;

                Weapon weapon = inventory[i] as Weapon;
                if (!(weapon.Info.GetWeaponType == weaponType))
                    continue;

                if (equipments != null)
                {
                    // 이전 장착된 것 해제
                    equipments.getPictureBox.BorderStyle = BorderStyle.None;
                }

                // 새로 장착
                equipments = weapon;
                equipments.getPictureBox.BorderStyle = BorderStyle.FixedSingle;
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
