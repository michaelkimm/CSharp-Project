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
        protected UsableItemInfo info;

        public Potion(Game game, PictureBox pictureBox, Point pose, UsableItemInfo info)
            : base(game, pictureBox, pose)
        {
            this.info = info;
        }
        public Potion(Game game, PictureBox pictureBox, int x, int y, UsableItemInfo info)
            : base(game, pictureBox, x, y)
        {
            this.info = info;
        }

        public UsableItemInfo Info { get { return info; } }

        public abstract void Use(GameUnit gameUnit);
    }

    class RedPotion : Potion
    {
        public RedPotion(Game game, PictureBox pictureBox, Point pose, UsableItemInfo info)
            : base(game, pictureBox, pose, info) { }
        public RedPotion(Game game, PictureBox pictureBox, int x, int y, UsableItemInfo info)
            : base(game, pictureBox, x, y, info) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.HpChange(info.Value);
            ActivePicture(false);
        }
    }

    class BluePotion : Potion
    {
        public BluePotion(Game game, PictureBox pictureBox, Point pose, UsableItemInfo info)
            : base(game, pictureBox, pose, info) { }
        public BluePotion(Game game, PictureBox pictureBox, int x, int y, UsableItemInfo info)
            : base(game, pictureBox, x, y, info) { }

        public override void Use(GameUnit gameUnit)
        {
            gameUnit.MpChange(info.Value);
            ActivePicture(false);
        }
    }
}
