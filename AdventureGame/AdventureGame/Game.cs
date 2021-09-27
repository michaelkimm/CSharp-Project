using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    class Game
    {
        Player player;
        Enemy[] enemies;
        Item[] itemData;
        List<Item> inGameItems;

        Rectangle boundary;
        Random randomMaker;

        public Game(Player player, Enemy[] enemies, Item[] itemdata, Rectangle boundary) //, Enemy[] enemys, Item[] items)
        {
            this.player = player;
            this.enemies = enemies;
            this.itemData = itemdata;
            this.boundary = boundary;
            inGameItems = new List<Item>();
            randomMaker = new Random();
        }

        public void Move(EnumClass.MoveDir dir)
        {
            // 플레이어 움직임 & 아이템 획득
            player.Move(dir);
            Item foundItem = player.FindCollision(inGameItems);
            if (foundItem != null)
            {
                MessageBox.Show("Found Item");
                player.GetItem(foundItem);
                inGameItems.Remove(foundItem);
            }

            // 적 움직임 & 공격
            MoveEnemy();
        }

        private void MoveEnemy()
        {
            Random random = new Random();
            Type type = typeof(EnumClass.MoveDir);

            Array values = type.GetEnumValues();

            foreach (Enemy enemy in enemies)
            {
                int index = random.Next(values.Length);
                EnumClass.MoveDir moveDir = (EnumClass.MoveDir)values.GetValue(index);

                enemy.Move(moveDir);
                if (enemy.Detected(player, EnumClass.MoveDir.None))
                    enemy.Attack(player);
            }
        }

        public void Attack(EnumClass.MoveDir dir)
        {
            foreach (Enemy enemy in enemies)
            {
                if (player.Detected(enemy, dir))
                    player.Attack(enemy);
            }
        }

        public void UpdateStep()
        {
            player.UpdateVisibleInfo();

            foreach (Enemy enemy in enemies)
            {
                enemy.UpdateVisibleInfo();
            }

            foreach (Item item in inGameItems)
            {
                item.UpdateVisibleInfo();
            }
        }

        public void GenerateItem()
        {
            // itemData에서 랜덤으로 1개 택하여 아이템 생성
            Weapon weapon = itemData[0] as Weapon;
            Weapon newWeapon = new Weapon(weapon.PbIngameItem, weapon.PbInventoryItem, GetRandomPosition(), weapon.Power, weapon.Name);
            newWeapon.ActiveIngame(true);
            inGameItems.Add(newWeapon);

            weapon = itemData[1] as Weapon;
            newWeapon = new Weapon(weapon.PbIngameItem, weapon.PbInventoryItem, GetRandomPosition(), weapon.Power, weapon.Name);
            newWeapon.ActiveIngame(true);
            inGameItems.Add(newWeapon);

            RedPotion redPotion = itemData[3] as RedPotion;
            RedPotion newRedPotion = new RedPotion(redPotion.PbIngameItem, redPotion.PbInventoryItem, GetRandomPosition(), redPotion.Amount, redPotion.Name);
            newRedPotion.ActiveIngame(true);
            inGameItems.Add(newRedPotion);
        }

        private Point GetRandomPosition()
        {
            return new Point(randomMaker.Next(boundary.X, boundary.X + boundary.Width), randomMaker.Next(boundary.Y, boundary.Y + boundary.Height));
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public void Use(string consumableItem)
        {
            player.Use(consumableItem);
        }
    }
}
