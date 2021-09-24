using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Game
    {
        //static Game instance = null;
        //public static Game Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Game();

        //        return instance;
        //    }
        //}

        Player player;
        Enemy[] enemies;
        Item[] items;

        public Game (Player player, Enemy[] enemies) //, Enemy[] enemys, Item[] items, Item[] equipments)
        {
            this.player = player;
            this.enemies = enemies;
            //this.items = items;
            //this.equipments = equipments;
        }

        public void Move(EnumClass.MoveDir dir)
        {
            player.Move(dir);

            foreach (Enemy enemy in enemies)
            {
                enemy.Move(dir);
                if (enemy.Detected(player))
                    enemy.Attack(player);
            }
        }

        public void Attack(EnumClass.MoveDir dir)
        {
            foreach (Enemy enemy in enemies)
            {
                if (player.Detected(enemy))
                    player.Attack(enemy);
            }
        }

        public void UpdateStep()
        {
            player.UpdateVisibleInfo();

            //foreach (Enemy enemy in enemies)
            //{
            //    enemy.UpdateVisibleInfo();
            //}
        }
    }
}
