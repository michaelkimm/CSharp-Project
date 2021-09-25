using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
    abstract class Item
    {
        protected PictureBox unitPictureBox;
        protected Point pose;

        public Item(PictureBox pictureBox, Point pose)
        {
            unitPictureBox = pictureBox;
            this.pose = pose;
        }
        public Item(PictureBox pictureBox, int x, int y)
        {
            unitPictureBox = pictureBox;
            this.pose = new Point(x, y);
        }

        public PictureBox UnitPictureBox { get { return unitPictureBox; } }
        public Point Pose { get { return pose; } }
    }
}
