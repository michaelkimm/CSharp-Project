using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdventureGame
{
    class Enemy : GameUnit
    {

        public Enemy (PictureBox pictureBox, Label label, Point pose, int speed, int initialHitPoint, int power, int detectLength)
            : base(pictureBox, label, pose, speed, initialHitPoint, power, detectLength)
        {

        }

        public Enemy(PictureBox pictureBox, Label label, int x, int y, int speed, int initialHitPoint, int power, int detectLength)
            : base(pictureBox, label, x, y, speed, initialHitPoint, power, detectLength)
        {

        }

        public override bool Detected(GameUnit gameUnit)
        {
            if (!(gameUnit is Player))
                return false;

            Player player = gameUnit as Player;
            if ((player.Pose.X - this.Pose.X) * (player.Pose.X - this.Pose.X) + (player.Pose.Y - this.Pose.Y) * (player.Pose.Y - this.Pose.Y) <= detectLength * detectLength)
                return true;
            else
                return false;
        }

        public override void Attack(GameUnit gameUnit)
        {
            if (!(gameUnit is Player))
                return;

            if (IsDead) return;
            if (gameUnit.IsDead) return;

            Player player = gameUnit as Player;
            player.Attacked(power);
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

