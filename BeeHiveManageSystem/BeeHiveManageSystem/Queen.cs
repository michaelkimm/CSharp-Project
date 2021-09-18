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
            string result = "";
            
            // 한번씩 실행
            foreach (Worker worker in workers)
                result += worker.WorkOneShift();

            // Bee 상태 report에 업데이트
            return result;
        }
    }
}
