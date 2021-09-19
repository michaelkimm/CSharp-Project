using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManageSystem
{
    class Queen
    {
        Worker[] workers;
        int shiftNumber = 0;    // total shift number

        public Queen(Worker[] workers)
        {
            this.workers = workers;
        }

        public bool AssignWork(string workName, int timeCost)
        {
            foreach (Worker worker in workers)
            {
                if (worker.DoThisJob(workName, timeCost))
                    return true;
            }
            return false;
        }
        
        // 일벌들에게 단위 시간 일을 시키고, 보고서를 반환하여 report에 업데이트
        public string WorkTheNextShift()
        {
            shiftNumber++;
            string result = "Report for shift #" + shiftNumber.ToString() + "\r\n";
            
            // 한번씩 실행
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    result += "Worker #" + (i + 1).ToString() + " finished the job\r\n";

                if (string.IsNullOrEmpty(workers[i].CurrentJob))
                    result += "Worker #" + (i + 1).ToString() + " is not working\r\n";
                else if (workers[i].ShiftLeft >= 2)
                    result += "Worker #" + (i + 1).ToString() + " is doing '" + workers[i].CurrentJob + "' for " + workers[i].ShiftLeft + " more shifts\r\n";
                else if (workers[i].ShiftLeft == 1)
                    result += "Worker #" + (i + 1).ToString() + " will be done with '" + workers[i].CurrentJob + "' after this shift\r\n";
            }

            // Bee 상태 report에 업데이트
            return result;
        }
    }
}
