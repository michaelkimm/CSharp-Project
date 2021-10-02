using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AdventureGame
{
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

    struct ItemInfo
    {
    }

    class Game
    {
        Player player;
        public List<Enemy> enemies;
        List<Item> itemData;
        public Dictionary<string, GameObjectDB> gameObjDB;
        public List<Item> inGameItems;

        Map map;
        Random randomMaker;

        public Game(Dictionary<string, GameObjectDB> gameObjDB, List<Item> itemdata, Map map) //, Enemy[] enemys, Item[] items)
        {
            this.gameObjDB = gameObjDB;
            this.itemData = itemdata;
            this.map = map;
            inGameItems = new List<Item>();
            randomMaker = new Random();

            InitializePlayer();
        }

        void InitializePlayer()
        {
            int playerSpeed = 5;
            int playerHP = 20;
            int playerMP = 10;
            int playerPower = 1;
            int playerDetectLength = 30;
            PlayerCharacterInfo playerInfo = new PlayerCharacterInfo(playerSpeed, playerHP, playerMP, playerPower, playerDetectLength);

            player = new Player(this,
                                gameObjDB["Player"].Name,
                                gameObjDB["Player"].GetIngamePictureBox(),
                                gameObjDB["Player"].GetLabel(), 
                                map.Start,
                                playerInfo);
        }

        void InitializeEnemy()
        {
            int batSpeed = 5;
            int batHP = 20;
            int batMP = 10;
            int batPower = 1;
            int batDetectLength = 30;
            PlayerCharacterInfo batInfo = new PlayerCharacterInfo(batSpeed, batHP, batMP, batPower, batDetectLength);

            int ghostSpeed = 5;
            int ghostHP = 20;
            int ghostMP = 10;
            int ghostPower = 1;
            int ghostDetectLength = 30;
            PlayerCharacterInfo ghostInfo = new PlayerCharacterInfo(ghostSpeed, ghostHP, ghostMP, ghostPower, ghostDetectLength);

            int ghoulSpeed = 5;
            int ghoulHP = 20;
            int ghoulMP = 10;
            int ghoulPower = 1;
            int ghoulDetectLength = 30;
            PlayerCharacterInfo ghoulInfo = new PlayerCharacterInfo(ghoulSpeed, ghoulHP, ghoulMP, ghoulPower, ghoulDetectLength);



            enemies.Add(new Enemy(this, gameObjDB["Bat"].Name, gameObjDB["Bat"].GetIngamePictureBox(), gameObjDB["Bat"].GetLabel(), 168, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
            enemies.Add(new Enemy(this, gameObjDB["Ghost"].Name, gameObjDB["Ghost"].GetIngamePictureBox(), gameObjDB["Ghost"].GetLabel(), 204, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
            enemies.Add(new Enemy(this, gameObjDB["Ghoul"].Name, gameObjDB["Ghoul"].GetIngamePictureBox(), gameObjDB["Ghoul"].GetLabel(), 240, 63, enemySpeed, enemyHitPoint, enemyMp, enemyPower, enemyDetectLength));
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

        public Item CreateItem(string itemName)
        {
            Item returnItem;
            switch (itemName)
            {
                case "RedPotion":
                    returnItem = new RedPotion(this,
                                               this.gameObjDB[itemName].GetInventoryPictureBox(),
                                               new Point(0, 0),
                                               this.gameObjDB[itemName].GetAbility(),
                                               itemName);
                    break;
                case "BluePotion":
                    returnItem = new BluePotion(this,
                                                this.gameObjDB[itemName].GetInventoryPictureBox(),
                                                new Point(0, 0),
                                                this.gameObjDB[itemName].GetAbility(),
                                                itemName);
                    break;
                case "Sword":
                    returnItem = new Weapon(this,
                                              this.gameObjDB[itemName].GetInventoryPictureBox(),
                                              new Point(0, 0),
                                              this.gameObjDB[itemName].GetAbility(),
                                              itemName);
                    break;
                case "Bow":
                    returnItem = new Weapon(this,
                                            this.gameObjDB[itemName].GetInventoryPictureBox(),
                                            new Point(0, 0),
                                            this.gameObjDB[itemName].GetAbility(),
                                            itemName);
                    break;
                case "Maze":
                    returnItem = new Weapon(this,
                                             this.gameObjDB[itemName].GetInventoryPictureBox(),
                                             new Point(0, 0),
                                             this.gameObjDB[itemName].GetAbility(),
                                             itemName);
                    break;
                default:
                    return null;
            }
            return returnItem;
        }

        public void GenerateItem()
        {
            // itemData에서 랜덤으로 1개 택하여 아이템 생성
            Weapon weapon = itemData[0] as Weapon;
            Weapon newWeapon = new Weapon(this, weapon.PbIngameItem, weapon.PbInventoryItem, GetRandomPosition(), weapon.Power, weapon.Name);
            newWeapon.ActiveIngame(true);
            inGameItems.Add(newWeapon);

            weapon = itemData[1] as Weapon;
            newWeapon = new Weapon(this, weapon.PbIngameItem, weapon.PbInventoryItem, GetRandomPosition(), weapon.Power, weapon.Name);
            newWeapon.ActiveIngame(true);
            inGameItems.Add(newWeapon);

            RedPotion redPotion = itemData[3] as RedPotion;
            RedPotion newRedPotion = new RedPotion(this, redPotion.PbIngameItem, redPotion.PbInventoryItem, GetRandomPosition(), redPotion.Amount, redPotion.Name);
            newRedPotion.ActiveIngame(true);
            inGameItems.Add(newRedPotion);
        }

        private Point GetRandomPosition()
        {
            return new Point(randomMaker.Next(boundary.X, boundary.X + boundary.Width), randomMaker.Next(boundary.Y, boundary.Y + boundary.Height));
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        public void Use(string consumableItem)
        {
            player.Use(consumableItem);
        }
    }
}
