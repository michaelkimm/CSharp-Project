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

        public Weapon(PictureBox pictureBox, Point pose, int power)
            : base(pictureBox, pose)
        {
            this.power = power;
        }

        public Weapon(PictureBox pictureBox, int x, int y, int power)
            : base(pictureBox, x, y)
        {
            this.power = power;
        }

        public int Power { get { return power; } }
        public void Attack(GameUnit gameUnit, int plusPower)
        {
            gameUnit.Attacked(Power + plusPower);
        }
    }
}
