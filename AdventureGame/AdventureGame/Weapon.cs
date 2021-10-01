using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    class Weapon : Item
    {
        int power;

        public Weapon(Game game, PictureBox pictureBox, Point pose, int power, string name)
            : base(game, pictureBox, pose, name)
        {
            this.power = power;
        }

        public Weapon(Game game, PictureBox pictureBox, int x, int y, int power, string name)
            : base(game, pictureBox, x, y, name)
        {
            this.power = power;
        }

        public int Power { get { return power; } }
        public void Attack(EnumClass.MoveDir dir, int UserPower)
        {
            for (int i = 0; i < game.enemies.Count; i++)
            {
                GameObject collidObj = this.CollisionWith(game.enemies[i]);
                if (collidObj == null)
                    continue;

                // 무기는 적을 공격한다
                Enemy enemy = collidObj as Enemy;
                enemy.Attacked(this.Power + UserPower);
                
            }
        }
    }
}
