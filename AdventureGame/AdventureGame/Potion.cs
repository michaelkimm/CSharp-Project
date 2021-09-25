using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    abstract class Potion : Item
    {
        protected int amount;

        public Potion(PictureBox pictureBox, Point pose, int amount)
            : base(pictureBox, pose)
        {
            this.amount = amount;
        }
        public Potion(PictureBox pictureBox, int x, int y, int amount)
            : base(pictureBox, x, y)
        {
            this.amount = amount;
        }

        public int Amount { get { return amount; } }

        public abstract void Use(GameUnit gameUnit, int plusAmount);
    }

    class RedPotion : Potion
    {
        public RedPotion(PictureBox pictureBox, Point pose, int amount)
            : base(pictureBox, pose, amount) { }
        public RedPotion(PictureBox pictureBox, int x, int y, int amount)
            : base(pictureBox, x, y, amount) { }

        public override void Use(GameUnit gameUnit, int plusAmount)
        {
            gameUnit.HpChange(amount + plusAmount);
        }
    }

    class BluePotion : Potion
    {
        public BluePotion(PictureBox pictureBox, Point pose, int amount)
            : base(pictureBox, pose, amount) { }
        public BluePotion(PictureBox pictureBox, int x, int y, int amount)
            : base(pictureBox, x, y, amount) { }

        public override void Use(GameUnit gameUnit, int plusAmount)
        {
            gameUnit.MpChange(amount + plusAmount);
        }
    }
}
