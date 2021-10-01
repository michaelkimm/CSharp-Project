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

        public Potion(Game game, PictureBox pictureBox, Point pose, int amount, string name)
            : base(game, pictureBox, pose, name)
        {
            this.amount = amount;
        }
        public Potion(Game game, PictureBox pictureBox, int x, int y, int amount, string name)
            : base(game, pictureBox, x, y, name)
        {
            this.amount = amount;
        }

        public int Amount { get { return amount; } }

        public abstract void Use(GameUnit gameUnit);
    }

    class RedPotion : Potion
    {
        public RedPotion(Game game, PictureBox pictureBox, Point pose, int amount, string name)
            : base(game, pictureBox, pose, amount, name) { }
        public RedPotion(Game game, PictureBox pictureBox, int x, int y, int amount, string name)
            : base(game, pictureBox, x, y, amount, name) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.HpChange(amount);
            ActivePicture(false);
        }
    }

    class BluePotion : Potion
    {
        public BluePotion(Game game, PictureBox pictureBox, Point pose, int amount, string name)
            : base(game, pictureBox, pose, amount, name) { }
        public BluePotion(Game game, PictureBox pictureBox, int x, int y, int amount, string name)
            : base(game, pictureBox, x, y, amount, name) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.MpChange(amount);
            ActivePicture(false);
        }
    }
}
