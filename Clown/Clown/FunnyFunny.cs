using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    class FunnyFunny : IClown
    {
        private string funnyThingIHave = "";
        public string FunnyThingIHave
        {
            get { return funnyThingIHave; }
        }


        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            MessageBox.Show("Honk honk! I have a " + funnyThingIHave);
        }
    }
}
