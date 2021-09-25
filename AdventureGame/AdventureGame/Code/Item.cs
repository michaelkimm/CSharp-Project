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
        protected PictureBox pbIngameItem;//  unitPictureBox;
        protected PictureBox pbInventoryItem;
        private Point pose;
        string name;

        public Item(PictureBox pbIngameItem, PictureBox pbInventoryItem, Point pose, string name)
        {
            this.pbIngameItem = pbIngameItem;
            this.pbInventoryItem = pbInventoryItem;
            Pose = pose;
            pbIngameItem.Visible = false;
            this.name = name;

        }
        public Item(PictureBox pbIngameItem, PictureBox pbInventoryItem, int x, int y, string name)
        {
            this.pbIngameItem = pbIngameItem;
            this.pbInventoryItem = pbInventoryItem;
            Pose = new Point(x, y);
            pbIngameItem.Visible = false;
            this.name = name;
        }

        public void ActiveIngame(bool value)
        {
            pbIngameItem.Visible = value;
        }
        public void ActiveInventory(bool value)
        {
            pbInventoryItem.Visible = value;
        }

        public void UpdateVisibleInfo()
        {
            pbIngameItem.Location = pose;
            pbInventoryItem.Location = pose;
        }

        public PictureBox PbIngameItem { get { return pbIngameItem; } }
        public PictureBox PbInventoryItem { get { return pbInventoryItem; } }
        public string Name { get { return name; } }

        public Point Pose
        { 
            get 
            {
                return pose;
            }
            set 
            {
                pose = value;
                pbIngameItem.Location = pose;
                pbInventoryItem.Location = pose;
            }
        }
    }
}
