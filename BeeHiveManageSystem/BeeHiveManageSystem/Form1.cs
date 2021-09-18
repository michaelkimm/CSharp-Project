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
        Worker[] workers = new Worker[WORKER_CNT];


        Queen queen = new Queen(workers);
        

        public Form1()
        {
            InitializeComponent();

            InitializeBees();
        }

        void InitializeBees()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
