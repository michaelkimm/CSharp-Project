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

        public Enemy (Game game, PictureBox pictureBox, Label label, Point pose, PlayerCharacterInfo characterInfo)
            : base(game, pictureBox, label, pose, characterInfo)
        {

        }

        public Enemy(Game game, PictureBox pictureBox, Label label, int x, int y, PlayerCharacterInfo characterInfo)
            : base(game, pictureBox, label, x, y, characterInfo)
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

        public void AttackPlayer()
        {
            if (IsDead) return;

            GameObject collidObj = CollisionWith(game.player);
            if (collidObj == null)
                return;

            Player player = collidObj as Player;
            player.Attacked(power);
        }

        public override void Move(EnumClass.MoveDir dir)
        {
            base.Move(dir);

            GameObject collideObj = CollisionWith(game.player);
            if (collideObj == null)
                return;

            Player player = collideObj as Player;
            AttackPlayer();
        }
    }

}

