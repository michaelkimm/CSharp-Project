using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace AdventureGame
{
    public enum WeaponType { Sword, Bow, Maze };
    public enum EnemyType { Bat, Ghost, Ghoul };

    public enum UsableItemType { RedPotion, BluePotion };

    struct Map
    {
        Rectangle boundary;
        Point start;
        Point end;

        public Map(Rectangle boundary, Point start, Point end)
        {
            this.boundary = boundary;
            this.start = start;
            this.end = end;
        }

        public Rectangle Boundary { get { return boundary; } }
        public Point Start { get { return start; } }
        public Point End { get { return end; } }
    }

    struct PlayerCharacterInfo
    {
        int hp;
        int mp;
        int speed;
        int power;
        int detectLength;

        public PlayerCharacterInfo(int hp, int mp, int speed, int power, int detectLength)
        {
            this.hp = hp;
            this.mp = mp;
            this.speed = speed;
            this.power = power;
            this.detectLength = detectLength;
        }

        public int Hp { get { return hp; } }
        public int Mp { get { return mp; } }
        public int Speed { get { return speed; } }
        public int Power { get { return power; } }
        public int DetectLength { get { return detectLength; } }

    }

    struct WeaponInfo
    {
        WeaponType weaponType;
        int power;
        int attackRange;

        public WeaponInfo(WeaponType weaponType, int power, int attackRange)
        {
            this.weaponType = weaponType;
            this.power = power;
            this.attackRange = attackRange;
        }

        public WeaponType GetWeaponType { get { return weaponType; } }
        public int Power { get { return power; } }
        public int AttackRange { get { return attackRange; } }
    }

    struct UsableItemInfo
    {
        UsableItemType usableItemType;
        int value;
        
        public UsableItemInfo(UsableItemType usableItemType, int value)
        {
            this.usableItemType = usableItemType;
            this.value = value;
        }

        public UsableItemType GetUsableItemType { get { return usableItemType; } }
        public int Value { get { return value; } }
    }

    class Game
    {
        public Player player;
        public List<Enemy> enemies;
        public Dictionary<EnemyType, PlayerCharacterInfo> EnemyDB;
        List<Item> itemData;
        public Dictionary<string, GameObjectUIDB> GameObjDB;
        public Dictionary<WeaponType, WeaponInfo> WeaponDB;
        public Dictionary<UsableItemType, UsableItemInfo> UsableItemDB;
        public List<Item> inGameItems;

        Map map;
        Random randomMaker;

        public Game(Dictionary<string, GameObjectUIDB> gameObjDB, Map map) //, Enemy[] enemys, Item[] items)
        {
            this.GameObjDB = gameObjDB;
            this.map = map;
            inGameItems = new List<Item>();
            randomMaker = new Random();

            LoadEnemyInfoDB();
            LoadItemInfoDB();

            InitializePlayer();
            InitializeItem();
        }

        void InitializePlayer()
        {
            int playerSpeed = 5;
            int playerHP = 20;
            int playerMP = 10;
            int playerPower = 1;
            int playerDetectLength = 30;
            string playerName = "Player";
            PlayerCharacterInfo playerInfo = new PlayerCharacterInfo(playerSpeed, playerHP, playerMP, playerPower, playerDetectLength);

            player = new Player(this,
                                playerName,
                                GameObjDB["Player"].GetIngamePictureBox(),
                                GameObjDB["Player"].GetLabel(), 
                                map.Start,
                                playerInfo);
        }

        void LoadEnemyInfoDB()
        {
            int batSpeed = 5;
            int batHP = 10;
            int batMP = 10;
            int batPower = 1;
            int batDetectLength = 30;
            Point batPosition = new Point(168, 63);
            PlayerCharacterInfo batInfo = new PlayerCharacterInfo(batSpeed, batHP, batMP, batPower, batDetectLength);

            int ghostSpeed = 10;
            int ghostHP = 15;
            int ghostMP = 10;
            int ghostPower = 3;
            int ghostDetectLength = 30;
            Point ghostPosition = new Point(168, 63);
            PlayerCharacterInfo ghostInfo = new PlayerCharacterInfo(ghostSpeed, ghostHP, ghostMP, ghostPower, ghostDetectLength);

            int ghoulSpeed = 20;
            int ghoulHP = 7;
            int ghoulMP = 10;
            int ghoulPower = 5;
            int ghoulDetectLength = 30;
            Point ghoulPosition = new Point(168, 63);
            PlayerCharacterInfo ghoulInfo = new PlayerCharacterInfo(ghoulSpeed, ghoulHP, ghoulMP, ghoulPower, ghoulDetectLength);


            EnemyDB.Add(EnemyType.Bat, batInfo);
            EnemyDB.Add(EnemyType.Ghost, ghostInfo);
            EnemyDB.Add(EnemyType.Ghoul, ghoulInfo);

            // enemies.Add(new Enemy(this, GameObjDB["Bat"].b, GameObjDB["Bat"].GetIngamePictureBox(), GameObjDB["Bat"].GetLabel(), batPosition, batInfo));
            // enemies.Add(new Enemy(this, GameObjDB["Ghost"].Name, GameObjDB["Ghost"].GetIngamePictureBox(), GameObjDB["Ghost"].GetLabel(), ghostPosition, ghostInfo));
            // enemies.Add(new Enemy(this, GameObjDB["Ghoul"].Name, GameObjDB["Ghoul"].GetIngamePictureBox(), GameObjDB["Ghoul"].GetLabel(), ghoulPosition, ghoulInfo));
        }

        void LoadItemInfoDB()
        {
            // 무기 데이터 업로드
            int swordPower = 1;
            int swordAttackRange = 5;
            WeaponInfo swordInfo = new WeaponInfo(WeaponType.Sword, swordPower, swordAttackRange);

            int bowPower = 2;
            int bowAttackRange = 10;
            WeaponInfo bowInfo = new WeaponInfo(WeaponType.Bow, bowPower, bowAttackRange);

            int mazePower = 3;
            int mazeAttackRange = 3;
            WeaponInfo mazeInfo = new WeaponInfo(WeaponType.Maze, mazePower, mazeAttackRange);

            WeaponDB.Add(WeaponType.Sword, swordInfo);
            WeaponDB.Add(WeaponType.Bow, bowInfo);
            WeaponDB.Add(WeaponType.Maze, mazeInfo);



            // 소비 가능한 아이템 데이터 업로드
            int hpPlus = 5;
            UsableItemInfo redPotionInfo = new UsableItemInfo(UsableItemType.RedPotion, hpPlus);

            int mpPlus = 5;
            UsableItemInfo bluePotionInfo = new UsableItemInfo(UsableItemType.BluePotion, mpPlus);

            UsableItemDB.Add(UsableItemType.RedPotion, redPotionInfo);
            UsableItemDB.Add(UsableItemType.BluePotion, bluePotionInfo);
        }

        void InitializeItem()
        {
            itemData.Add(new Weapon(this, GameObjDB["Sword"].GetIngamePictureBox(), 0, 0, WeaponDB[WeaponType.Sword]));
            itemData.Add(new Weapon(this, GameObjDB["Bow"].GetIngamePictureBox(), 0, 0, WeaponDB[WeaponType.Bow]));
            itemData.Add(new Weapon(this, GameObjDB["Maze"].GetIngamePictureBox(), 0, 0, WeaponDB[WeaponType.Maze]));
            itemData.Add(new RedPotion(this, GameObjDB["RedPotion"].GetIngamePictureBox(), 0, 0, UsableItemDB[UsableItemType.RedPotion]));
            itemData.Add(new BluePotion(this, GameObjDB["BluePotion"].GetIngamePictureBox(), 0, 0, UsableItemDB[UsableItemType.BluePotion]));
        }

        public void Move(EnumClass.MoveDir dir, Random random)
        {
            // 플레이어 움직임 & 아이템 획득
            player.Move(dir);
            
            // 적 움직임 & 공격
            MoveEnemy(random);
        }

        private void MoveEnemy(Random random)
        {
            Type type = typeof(EnumClass.MoveDir);

            Array values = type.GetEnumValues();

            foreach (Enemy enemy in enemies)
            {
                // 움직일 방향 랜덤으로 선정
                int index = random.Next(values.Length);
                EnumClass.MoveDir moveDir = (EnumClass.MoveDir)values.GetValue(index);

                enemy.Move(moveDir);
            }
        }

        public void Attack(EnumClass.MoveDir dir, Random random)
        {
            player.Attack(dir);

            // 적 움직임 & 공격
            MoveEnemy(random);
        }

        public void UpdateStep()
        {
            player.UpdateVisibleInfo();

            foreach (Enemy enemy in enemies)
            {
                enemy.UpdateVisibleInfo();
            }

            foreach (Item item in inGameItems)
            {
                item.UpdateVisibleInfo();
            }
        }

        public Item CreateItem(string itemName, bool isIngame)
        {
            Item returnItem;

            PictureBox pictureBox = null;
            if (isIngame)
                pictureBox = this.GameObjDB[itemName].GetIngamePictureBox();
            else
                pictureBox = this.GameObjDB[itemName].GetInventoryPictureBox();

            switch (itemName)
            {
                case "RedPotion":
                    returnItem = new RedPotion(this,
                                               pictureBox,
                                               new Point(0, 0),
                                               UsableItemDB[UsableItemType.RedPotion]);
                    break;
                case "BluePotion":
                    returnItem = new BluePotion(this,
                                                pictureBox,
                                                new Point(0, 0),
                                                UsableItemDB[UsableItemType.BluePotion]);
                    break;
                case "Sword":
                    returnItem = new Weapon(this,
                                            pictureBox,
                                            new Point(0, 0),
                                            WeaponDB[WeaponType.Sword]);
                    break;
                case "Bow":
                    returnItem = new Weapon(this,
                                            pictureBox,
                                            new Point(0, 0),
                                            WeaponDB[WeaponType.Bow]);
                    break;
                case "Maze":
                    returnItem = new Weapon(this,
                                            pictureBox,
                                            new Point(0, 0),
                                            WeaponDB[WeaponType.Maze]);
                    break;
                default:
                    return null;
            }
            return returnItem;
        }

        public void GenerateItem()
        {
            inGameItems.Add(CreateItem("Sword", true));
            inGameItems.Add(CreateItem("Bow", true));
            inGameItems.Add(CreateItem("Maze", true));
            inGameItems.Add(CreateItem("RedPotion", true));
            inGameItems.Add(CreateItem("BluePotion", true));
        }

        private Point GetRandomPosition()
        {
            return new Point(randomMaker.Next(map.Boundary.X, map.Boundary.X + map.Boundary.Width), randomMaker.Next(map.Boundary.Y, map.Boundary.Y + map.Boundary.Height));
        }

        public void Equip(WeaponType weaponType)
        {
            player.Equip(weaponType);
        }

        public void Use(string consumableItem)
        {
            player.Use(consumableItem);
        }
    }
}
