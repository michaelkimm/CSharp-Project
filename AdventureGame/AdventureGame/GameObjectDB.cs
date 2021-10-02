using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    class GameObjectUIDB
    {
        PictureBox pbIngame;
        PictureBox pbInventory;
        Label lbUI;

        public GameObjectUIDB(PictureBox pbIngame, PictureBox pbInventory = null, Label lbUI = null)
        {
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
    }
}
