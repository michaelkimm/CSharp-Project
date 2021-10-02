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
        WeaponInfo info;

        public Weapon(Game game, PictureBox pictureBox, Point pose, WeaponInfo weaponInfo)
            : base(game, pictureBox, pose)
        {
            this.info = weaponInfo;
        }

        public Weapon(Game game, PictureBox pictureBox, int x, int y, WeaponInfo weaponInfo)
            : base(game, pictureBox, x, y)
        {
            this.info = weaponInfo;
        }

        public WeaponInfo Info { get { return info; } }
        public void Attack(EnumClass.MoveDir dir, int UserPower)
        {
            for (int i = 0; i < game.enemies.Count; i++)
            {
                GameObject collidObj = this.CollisionWith(game.enemies[i]);
                if (collidObj == null)
                    continue;

                // 무기는 적을 공격한다
                Enemy enemy = collidObj as Enemy;
                enemy.Attacked(this.info.Power + UserPower);
                
            }
        }
    }
}
