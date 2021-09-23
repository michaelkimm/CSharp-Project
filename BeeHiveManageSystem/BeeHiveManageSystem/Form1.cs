using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeeHiveManageSystem
{
    public partial class Form1 : Form
    {
        const int WORKER_CNT = 4;
        Queen queen;
        

        public Form1()
        {
            InitializeComponent();

            InitializeBees();
        }

        void InitializeBees()
        {
            Worker[] workers = new Worker[WORKER_CNT];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufaturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufaturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);

            queen = new Queen(workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AssignButton_Click(object sender, EventArgs e)
        {

            // WorkerBeeJob에서 할당된 일 & shifts에서 할당된 shift 수를 가져와서 Bee에게 할당. 할당 성공 여부에 따라 messageBox 출력 (성공, 실패<가능, 할 사람 없음>)
            if (queen.AssignWork(WorkerBeeJob.Text, (int)shifts.Value))
            {
                MessageBox.Show("The job '" + WorkerBeeJob.Text + "' will be done in " + (int)shifts.Value + " shifts");
            }
            else
            {
                MessageBox.Show("Can't be assigned! you might not have bee to work or workable bee can't do " + WorkerBeeJob.SelectedText);
            }
        }

        private void WorkerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void shifts_ValueChanged(object sender, EventArgs e)
        {

        }

        private void NextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }

        private void Report_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
