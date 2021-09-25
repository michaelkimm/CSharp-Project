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
        int playerMp = 15;
        int playerPower = 1;
        int playerDetectLength = 30;

        int enemyHitPoint = 10;
        int enemyMp = 15;
        int enemySpeed = 8;
        int enemyPower = 1;
        int enemyDetectLength = 30;

        Game gameManager;
        Player player;
        Enemy[] enemys;
        Item[] itemdata;
        Rectangle boundary;

        public Form1()
        {
            InitializeComponent();

            InitializeGame();
        }

        void InitializeGame()
        {
            player = new Player(pbPlayer, lbPlayer ,96, 63, playerSpeed, playerHitPoint, playerMp, playerPower, playerDetectLength);

            InitializeEnemy();
            InitializeItem();
            InitializeMap();
            gameManager = new Game(player, enemys, itemdata, boundary);
        }

        void InitializeEnemy()
        {
            enemys = new Enemy[3];
            
            enemys[0] = new Enemy(pbBat, lbBat, 168, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength);
            enemys[1] = new Enemy(pbGhost, lbGhost, 204, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength);
            enemys[2] = new Enemy(pbGhoul, lbGhoul, 240, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength);
        }

        void InitializeItem()
        {
            itemdata = new Item[5];
            itemdata[0] = new Weapon(pbSwordItem, pbSwordEquipped, 0, 0, 1, "Sword");
            itemdata[1] = new Weapon(pbBowItem, pbBowEquipped, 0, 0, 2, "Bow");
            itemdata[2] = new Weapon(pbMazeItem, pbMaceEquipped, 0, 0, 3, "Maze");
            itemdata[3] = new RedPotion(pbPotionRedItem, pbPotionRedEquipped, 0, 0, 5, "RedPotion");
            itemdata[4] = new BluePotion(pbPotionBlueItem, pbPotionBlueEquipped, 0, 0, 5, "BluePotion");
        }
        void InitializeMap()
        {
            boundary = new Rectangle(0, 0, 600, 300);
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

        private void pbSwordEquipped_Click(object sender, EventArgs e)
        {
            gameManager.Equip("Sword");
        }

        private void btnAtkUp_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Up);
            gameManager.UpdateStep();
        }

        private void btnAtkLeft_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Left);
            gameManager.UpdateStep();
        }

        private void btnAtkRight_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Right);
            gameManager.UpdateStep();
        }

        private void btnAtkDown_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Down);
            gameManager.UpdateStep();
        }

        private void btnItemGenerator_Click(object sender, EventArgs e)
        {
            gameManager.GenerateItem();
            gameManager.UpdateStep();
        }

        private void pbPotionRedEquipped_Click(object sender, EventArgs e)
        {
            gameManager.Use("RedPotion");
            gameManager.UpdateStep();
        }

        private void pbPotionBlueEquipped_Click(object sender, EventArgs e)
        {
            gameManager.Use("RedPotion");
            gameManager.UpdateStep();
        }

        private void pbBowEquipped_Click(object sender, EventArgs e)
        {
            gameManager.Equip("Bow");
        }

        private void pbMaceEquipped_Click(object sender, EventArgs e)
        {
            gameManager.Equip("Mace");
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
