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
        int ability;

        public GameObjectDB(string name, PictureBox pbIngame, PictureBox pbInventory, int ability)
        {
            this.name = name;
            this.pbIngame = pbIngame;
            this.pbInventory = pbInventory;
            this.ability = ability;
        }

        public PictureBox GetIngamePictureBox()
        {
            return pbIngame;
        }

        public PictureBox GetInventoryPictureBox()
        {
            return pbInventory;
        }

        public int GetAbility()
        {
            return ability;
        }

        public string Name
        {
            get { return name; }
        }
    }
}
