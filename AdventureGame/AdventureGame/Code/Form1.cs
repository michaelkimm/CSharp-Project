using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int playerSpeed = 10;
        int playerHitPoint = 15;
        int playerPower = 1;
        int playerDetectLength = 30;

        int enemyHitPoint = 10;
        int enemySpeed = 8;
        int enemyPower = 1;
        int enemyDetectLength = 30;

        Game gameManager;
        Player player;
        Enemy[] enemys;
        Item[] items;
        Item[] equipments;

        public Form1()
        {
            InitializeComponent();

            InitializeGame();
        }

        void InitializeGame()
        {
            player = new Player(pbPlayer, lbPlayer ,96, 63, playerSpeed, playerHitPoint, playerPower, playerDetectLength);

            InitializeEnemy();

            gameManager = new Game(player, enemys);
        }

        void InitializeEnemy()
        {
            enemys = new Enemy[3];
            
            enemys[0] = new Enemy(pbBat, lbBat, 168, 63, enemySpeed, enemyHitPoint, enemyPower, enemyDetectLength);
            enemys[1] = new Enemy(pbGhost, lbGhost, 204, 63, enemySpeed, enemyHitPoint, enemyPower, enemyDetectLength);
            enemys[2] = new Enemy(pbGhoul, lbGhoul, 240, 63, enemySpeed, enemyHitPoint, enemyPower, enemyDetectLength);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Up);
            gameManager.UpdateStep();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Right);
            gameManager.UpdateStep();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Left);
            gameManager.UpdateStep();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Down);
            gameManager.UpdateStep();
        }

        private void lbPlayer_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}

        //private void button4_Click(object sender, EventArgs e)
        //{

        //}

        //private void button3_Click(object sender, EventArgs e)
        //{

        //}

        //private void button8_Click(object sender, EventArgs e)
        //{

        //}

        //private void button7_Click(object sender, EventArgs e)
        //{

        //}

        //private void button5_Click(object sender, EventArgs e)
        //{

        //}

        //private void button6_Click(object sender, EventArgs e)
        //{

        //}
    }
}
