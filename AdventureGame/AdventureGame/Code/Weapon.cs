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

        public Weapon(PictureBox pbIngame, PictureBox pbInventory, Point pose, int power, string name)
            : base(pbIngame, pbInventory, pose, name)
        {
            this.power = power;
        }

        public Weapon(PictureBox pbIngame, PictureBox pbInventory, int x, int y, int power, string name)
            : base(pbIngame, pbInventory, x, y, name)
        {
            this.power = power;
        }

        public int Power { get { return power; } }
        public void Attack(GameUnit gameUnit, int plusPower)
        {
            // 무기는 목표물을 공격한다
            gameUnit.Attacked(Power + plusPower);
        }
    }
}
