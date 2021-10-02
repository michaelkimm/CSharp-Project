using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class GameObjectDB
    {
        string name;
        PictureBox pbIngame;
        PictureBox pbInventory;
        Label lbUI;

        public GameObjectDB(string name, PictureBox pbIngame, PictureBox pbInventory = null, Label lbUI = null)
        {
            this.name = name;
            this.pbIngame = pbIngame;
            this.pbInventory = pbInventory;
            this.lbUI = lbUI;
        }

        public PictureBox GetIngamePictureBox()
        {
            return pbIngame;
        }

        public PictureBox GetInventoryPictureBox()
        {
            return pbInventory;
        }

        public Label GetLabel()
        {
            return lbUI;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
