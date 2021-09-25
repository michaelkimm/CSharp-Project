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

        public Enemy (PictureBox pictureBox, Label label, Point pose, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, pose, speed, initialHitPoint, initialMp, power, detectLength)
        {

        }

        public Enemy(PictureBox pictureBox, Label label, int x, int y, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, x, y, speed, initialHitPoint, initialMp, power, detectLength)
        {

        }

        public override bool Detected(GameUnit gameUnit, EnumClass.MoveDir dir)
        {
            bool result = false;

            if (!(gameUnit is Player))
                return false;

            Player player = gameUnit as Player;
            if ((player.Pose.X - this.Pose.X) * (player.Pose.X - this.Pose.X) + (player.Pose.Y - this.Pose.Y) * (player.Pose.Y - this.Pose.Y) <= detectLength * detectLength)
                result = true;
            else
                return false;

            switch (dir)
            {
                case EnumClass.MoveDir.Left:
                    if (!((this.Pose.X - player.Pose.X) >= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Up:
                    if (!((this.Pose.Y - player.Pose.Y) >= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Right:
                    if (!((this.Pose.X - player.Pose.X) <= 0))
                    {
                        result = false;
                    }
                    break;
                case EnumClass.MoveDir.Down:
                    if (!((this.Pose.Y - player.Pose.Y) <= 0))
                    {
                        result = false;
                    }
                    break;
                default:
                    break;
            }

            return result;
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
    }
}

