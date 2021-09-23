using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clown
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        string scaryThingIHave = "";
        public string ScaryThingIHave { get { return scaryThingIHave; } }
        int numberOfScaryThings = 0;

        public ScaryScary (int numberOfScaryThings, string funnyThingIHave)
            : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
            this.scaryThingIHave = numberOfScaryThings.ToString() + " spiders";
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show("Boo! Gotcha!");
        }
    }
}
