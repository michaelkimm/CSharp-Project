using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManageSystem
{
    class Worker
    {
        private string currentJob = "";
        public string CurrentJob
        {
            get { return currentJob; }
            private set { currentJob = value; }
        }
        public int ShiftLeft { get; private set; }

        string[] jobsICanDo;
        int shiftsToWork = 0;
        int shiftsWorked = 0;

        public Worker(string[] jobsICanDo)
        {
            this.jobsICanDo = jobsICanDo;
        }

        public bool DoThisJob(string jobOrdered, int timeCost)
        {
            // 하고 있는 일이 있는가?
            if (!string.IsNullOrEmpty(currentJob))
                return false;

            // 할 수 있는 일에 포함 되는가?
            foreach (string jobsICanDo in jobsICanDo)
            {
                if (jobsICanDo == jobOrdered)
                {
                    shiftsToWork = timeCost;
                    shiftsWorked = 0;
                    currentJob = jobOrdered;
                    return true;
                }
            }

            return false;
        }

        public string WorkOneShift()
        {
            if (string.IsNullOrEmpty(currentJob))
                return "";

            shiftsToWork--;
            if (shiftsToWork < 0) shiftsToWork = 0;
            shiftsWorked++;

            return "Worker ";
        }
    }
}
