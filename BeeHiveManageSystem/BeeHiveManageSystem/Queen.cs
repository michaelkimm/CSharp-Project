using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            bool result = false;
            return result;
        }
        
        // 일벌들에게 단위 시간 일을 시키고, 보고서를 반환하여 report에 업데이트
        public void WorkTheNextShift()
        {

        }
    }
}
