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
        Game gameManager;
        List<Item> itemdata;
        Map map;
        Random random = new Random();

        Dictionary<string, GameObjectUIDB> gameObjectDataBase;
        Dictionary<WeaponType, WeaponInfo> weaponDB;

        public Form1()
        {
            InitializeComponent();

            LoadDB();

            InitializeGame();
        }

        void LoadDB()
        {
            // Player
            gameObjectDataBase.Add("Player", new GameObjectUIDB(pbPlayer, null));

            // Enemy
            gameObjectDataBase.Add("Bat", new GameObjectUIDB(pbBat, lbUI: lbBat));
            gameObjectDataBase.Add("Ghost", new GameObjectUIDB(pbGhost, lbUI: lbGhost));
            gameObjectDataBase.Add("Ghoul", new GameObjectUIDB(pbGhoul, lbUI: lbGhoul));

            // Weapon DB
            gameObjectDataBase.Add("Sword", new GameObjectUIDB(pbSwordItem, pbSwordEquipped));
            gameObjectDataBase.Add("Bow", new GameObjectUIDB(pbBowItem, pbBowEquipped));
            gameObjectDataBase.Add("Maze", new GameObjectUIDB(pbMazeItem, pbMaceEquipped));

            // Usable Item DB
            gameObjectDataBase.Add("RedPotion", new GameObjectUIDB(pbPotionRedItem, pbPotionRedEquipped));
            gameObjectDataBase.Add("BluePotion", new GameObjectUIDB(pbPotionBlueItem, pbPotionBlueEquipped));
        }

        void InitializeGame()
        {
            InitializeItem();
            InitializeMap();
            gameManager = new Game(gameObjectDataBase, map);

        }

        void InitializeItem()
        {
            int swordPower = 1;
            WeaponInfo swordInfo = new WeaponInfo(swordPower);

            int bowPower = 2;
            WeaponInfo bowInfo = new WeaponInfo(bowPower);

            int mazePower = 3;
            WeaponInfo mazeInfo = new WeaponInfo(mazePower);

            weaponDB.Add(WeaponType.Sword, swordInfo);
            weaponDB.Add(WeaponType.Bow, bowInfo);
            weaponDB.Add(WeaponType.Maze, mazeInfo);

            //itemdata.Add(new Weapon(gameManager, pbSwordItem, 0, 0, 1, "Sword"));
            //itemdata.Add(new Weapon(gameManager,pbBowItem, 0, 0, 2, "Bow"));
            //itemdata.Add(new Weapon(gameManager, pbMazeItem, 0, 0, 3, "Maze"));
            //itemdata.Add(new RedPotion(gameManager,pbPotionRedItem, 0, 0, 5, "RedPotion"));
            //itemdata.Add(new BluePotion(gameManager, pbPotionBlueItem, 0, 0, 5, "BluePotion"));
        }
        void InitializeMap()
        {
            Rectangle boundary = new Rectangle(0, 0, 600, 300);

            map = new Map(boundary,
                          new Point((int)((boundary.Bottom + boundary.Top) * 0.5f), (int)((boundary.Bottom + boundary.Top) * 0.1f)),
                          new Point((int)((boundary.Bottom + boundary.Top) * 0.5f), (int)((boundary.Bottom + boundary.Top) * 0.9f)));
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
