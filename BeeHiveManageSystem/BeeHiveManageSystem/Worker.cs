using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHiveManageSystem
{
    class Worker
    {
        public string currentJob { get; private set; }
        public int shiftLeft { get; private set; }

        string[] jobsICanDo;
        int shiftsToWork;
        int shiftsWorked;

        public bool DoThisJob(string jobOrdered, int timeCost)
        {
            bool result = false;
            return result;
        }

        public void WorkOneShift()
        {

        }
    }
}
