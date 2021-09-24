using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdventureGame
{
    class Player : GameUnit
    {
        Item equipments;
        List<Item> inventory;

        public Player(PictureBox pictureBox, Label label, Point pose, int speed, int initialHitPoint, int power)
            : base(pictureBox, label, pose, speed, initialHitPoint, power)
        {

        }
        public Player(PictureBox pictureBox, Label label, int x, int y, int speed, int initialHitPoint, int power)
            : base(pictureBox, label, x, y, speed, initialHitPoint, power)
        {

        }

        public bool Detected(Enemy enemy)
        {
            return true;
        }

        public void Attack(Enemy enemy)
        {
            if (IsDead) return;
        }

        public override void Move(EnumClass.MoveDir dir)
        {
            if (IsDead) return;
            
            switch (dir)
            {
                case EnumClass.MoveDir.Left:
                    pose.X -= speed;
                    break;
                case EnumClass.MoveDir.Up:
                    pose.Y -= speed;
                    break;
                case EnumClass.MoveDir.Right:
                    pose.X += speed;
                    break;
                case EnumClass.MoveDir.Down:
                    pose.Y += speed;
                    break;
            }
        }
    }
}
