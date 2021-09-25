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

        public Potion(PictureBox pbIngame, PictureBox pbInventory, Point pose, int amount, string name)
            : base(pbIngame, pbInventory, pose, name)
        {
            this.amount = amount;
        }
        public Potion(PictureBox pbIngame, PictureBox pbInventory, int x, int y, int amount, string name)
            : base(pbIngame, pbInventory, x, y, name)
        {
            this.amount = amount;
        }

        public int Amount { get { return amount; } }

        public abstract void Use(GameUnit gameUnit);
    }

    class RedPotion : Potion
    {
        public RedPotion(PictureBox pbIngame, PictureBox pbInventory, Point pose, int amount, string name)
            : base(pbIngame, pbInventory, pose, amount, name) { }
        public RedPotion(PictureBox pbIngame, PictureBox pbInventory, int x, int y, int amount, string name)
            : base(pbIngame, pbInventory, x, y, amount, name) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.HpChange(amount);
            ActiveInventory(false);
        }
    }

    class BluePotion : Potion
    {
        public BluePotion(PictureBox pbIngame, PictureBox pbInventory, Point pose, int amount, string name)
            : base(pbIngame, pbInventory, pose, amount, name) { }
        public BluePotion(PictureBox pbIngame, PictureBox pbInventory, int x, int y, int amount, string name)
            : base(pbIngame, pbInventory, x, y, amount, name) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.MpChange(amount);
            ActiveInventory(false);
        }
    }
}
