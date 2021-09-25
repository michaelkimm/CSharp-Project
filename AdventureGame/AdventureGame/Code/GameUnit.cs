using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdventureGame
{
    abstract class GameUnit
    {
        protected PictureBox unitPictureBox;
        protected Label unitLabel;
        protected int hitPoint = 0;
        protected Point pose;
        protected int speed;
        protected int power;
        protected int detectLength;

        public GameUnit(PictureBox pictureBox, Label unitLabel, Point pose, int speed, int initialHitPoint, int power, int detectLength)
        {
            unitPictureBox = pictureBox;
            this.unitLabel = unitLabel;
            this.pose = pose;
            this.speed = speed;
            hitPoint = initialHitPoint;
            this.power = power;
            this.detectLength = detectLength;
        }
        public GameUnit(PictureBox pictureBox, Label unitLabel, int x, int y, int speed, int initialHitPoint, int power, int detectLength)
        {
            unitPictureBox = pictureBox;
            this.unitLabel = unitLabel;
            this.pose = new Point(x, y);
            this.speed = speed;
            hitPoint = initialHitPoint;
            this.power = power;
            this.detectLength = detectLength;
        }

        public PictureBox UnitPictureBox { get { return unitPictureBox; } }

        public Label UnitLabel { get { return unitLabel; } }

        public int HitPoint { get { return hitPoint; } }

        public Point Pose { get { return pose; } }
        public int Speed { get { return speed; } }
        public int Power { get { return power; } }

        public bool IsDead
        {
            get
            {
                return unitPictureBox.Visible != true;
            }
        }

        public abstract void Move(EnumClass.MoveDir dir);
        public abstract void Attack(GameUnit gameUnit);
        public abstract bool Detected(GameUnit gameUnit);
        virtual public void Attacked(int hp)
        {
            hitPoint -= hp;
            if (hp <= 0)
                hp = 0;

            unitPictureBox.Visible = false;
        }

        public void UpdateVisibleInfo()
        {
            UpdatePose();
            UpdateHitPoint();
        }

        private void UpdatePose()
        {
            unitPictureBox.Location = pose;
        }
        private void UpdateHitPoint()
        {
            unitLabel.Text = hitPoint.ToString();
        }
    }
}
