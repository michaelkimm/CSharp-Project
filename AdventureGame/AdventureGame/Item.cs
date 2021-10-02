using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    abstract class Item : GameObject
    {
        protected PictureBox pictureBox;
        // protected PictureBox pbIngameItem;//  unitPictureBox;
        // protected PictureBox pbInventoryItem;

        public Item(Game game, PictureBox pictureBox, Point pose)
            : base(game)
        {
            this.pictureBox = pictureBox;
            Pose = pose;
            pictureBox.Visible = false;

        }
        public Item(Game game, PictureBox pictureBox, int x, int y)
            : base(game)
        {
            this.pictureBox = pictureBox;
            Pose = new Point(x, y);
            pictureBox.Visible = false;
        }

        public void ActivePicture(bool value)
        {
            pictureBox.Visible = value;
        }

        public void UpdateVisibleInfo()
        {
            pictureBox.Location = pose;
        }

        public PictureBox getPictureBox { get { return pictureBox; } }
        public Point Pose
        { 
            get 
            {
                return pose;
            }
            set 
            {
                pose = value;
                pictureBox.Location = pose;
            }
        }
    }
}
