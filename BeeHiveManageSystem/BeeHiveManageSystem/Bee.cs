using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManageSystem
{
    class Bee
    {
        public virtual int ShiftLeft
        {
            get { return 0; }
        }

        private float weight = 0f;
        public float Weight
        {
            get { return weight; }
        }

        public Bee (float weight)
        { this.weight = weight; }

        public virtual double GetHoneyConsumption()
        {
            double honeyConsumption = 0f;

            if (ShiftLeft == 0)
                honeyConsumption = 7.5f;
            else
                honeyConsumption = ShiftLeft + 9;

            if (weight > 150) honeyConsumption *= 1.35;

            return honeyConsumption;
        }
    }
}
