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
        List<Enemy> enemys;
        List<Item> itemdata;
        Rectangle boundary;
        Random random = new Random();

        Dictionary<string, GameObjectDB> gameObjectDataBase;

        public Form1()
        {
            InitializeComponent();

            LoadDB();

            InitializeGame();
        }
        void LoadDB()
        {
            // Weapon DB
            gameObjectDataBase.Add("Sword", new GameObjectDB("Sword", pbSwordItem, pbSwordEquipped, 1));
            gameObjectDataBase.Add("Bow", new GameObjectDB("Bow", pbBowItem, pbBowEquipped, 2));
            gameObjectDataBase.Add("Maze", new GameObjectDB("Maze", pbMazeItem, pbMaceEquipped, 3));

            // Usable Item DB
            gameObjectDataBase.Add("RedPotion", new GameObjectDB("RedPotion", pbPotionRedItem, pbPotionRedEquipped, 5));
            gameObjectDataBase.Add("BluePotion", new GameObjectDB("BluePotion", pbPotionBlueItem, pbPotionBlueEquipped, 10));
        }

        void InitializeGame()
        {

            InitializeEnemy();
            InitializeItem();
            InitializeMap();
            gameManager = new Game(gameObjectDataBase, player, enemys, itemdata, boundary);
            player = new Player(gameManager, pbPlayer, lbPlayer, 96, 63, playerSpeed, playerHitPoint, playerMp, playerPower, playerDetectLength);

        }

        void InitializeEnemy()
        {
            enemys.Add(new Enemy(gameManager, pbBat, lbBat, 168, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
            enemys.Add(new Enemy(gameManager, pbGhost, lbGhost, 204, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
            enemys.Add(new Enemy(gameManager, pbGhoul, lbGhoul, 240, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
        }

        void InitializeItem()
        {
            itemdata.Add(new Weapon(gameManager, pbSwordItem, pbSwordEquipped, 0, 0, 1, "Sword"));
            itemdata.Add(new Weapon(gameManager,pbBowItem, pbBowEquipped, 0, 0, 2, "Bow"));
            itemdata.Add(new Weapon(gameManager, pbMazeItem, pbMaceEquipped, 0, 0, 3, "Maze"));
            itemdata.Add(new RedPotion(gameManager,pbPotionRedItem, pbPotionRedEquipped, 0, 0, 5, "RedPotion"));
            itemdata.Add(new BluePotion(gameManager, pbPotionBlueItem, pbPotionBlueEquipped, 0, 0, 5, "BluePotion"));
        }
        void InitializeMap()
        {
            boundary = new Rectangle(0, 0, 600, 300);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Up, random);
            gameManager.UpdateStep();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Right, random);
            gameManager.UpdateStep();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Left, random);
            gameManager.UpdateStep();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            gameManager.Move(EnumClass.MoveDir.Down, random);
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
            gameManager.Attack(EnumClass.MoveDir.Up, random);
            gameManager.UpdateStep();
        }

        private void btnAtkLeft_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Left, random);
            gameManager.UpdateStep();
        }

        private void btnAtkRight_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Right, random);
            gameManager.UpdateStep();
        }

        private void btnAtkDown_Click(object sender, EventArgs e)
        {
            gameManager.Attack(EnumClass.MoveDir.Down, random);
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

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void pbBat_Click(object sender, EventArgs e)
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
