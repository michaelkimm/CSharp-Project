using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace AdventureGame
{

    public struct Ability
    {
        public int HitPoint;
        public int Mp;
        public int Speed;
        public int Power;
        public int DetectLength;

        public Ability(int initialHitPoint, int initialMp, int speed, int power, int detectLength)
        {
            this.HitPoint = initialHitPoint;
            this.Mp = initialMp;
            this.Speed = speed;
            this.Power = power;
            this.DetectLength = detectLength;
        }
    }
    abstract class GameUnit
    {
        protected PictureBox unitPictureBox;
        protected Label unitLabel;
        protected Point pose;
        // protected Ability ability;

        protected int hitPoint = 0;
        protected int mp = 0;
        protected int speed;
        protected int power;
        protected int detectLength;

        public GameUnit(PictureBox pictureBox, Label unitLabel, Point pose, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
        {
            unitPictureBox = pictureBox;
            this.unitLabel = unitLabel;
            this.pose = pose;
            hitPoint = initialHitPoint;
            mp = initialMp;
            this.speed = speed;
            this.power = power;
            this.detectLength = detectLength;
        }
        public GameUnit(PictureBox pictureBox, Label unitLabel, int x, int y, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
        {
            unitPictureBox = pictureBox;
            this.unitLabel = unitLabel;
            this.pose = new Point(x, y);
            this.speed = speed;
            hitPoint = initialHitPoint;
            mp = initialMp;
            this.power = power;
            this.detectLength = detectLength;
        }

        public PictureBox UnitPictureBox { get { return unitPictureBox; } }

        public Label UnitLabel { get { return unitLabel; } }

        public int HitPoint { get { return hitPoint; } }
        public int Mp { get { return mp; } }

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

        public void HpChange(int hp)
        {
            this.hitPoint += hp;
        }

        public void MpChange(int mp)
        {
            this.mp += mp;
        }

        public virtual void Move(EnumClass.MoveDir dir)
        {
            if (IsDead) return;

            Point prePose = pose;

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

            // 화면 밖으로 나가면, 원위치
            if (pose.X < 0 || pose.Y < 0 || pose.X > 600 || pose.Y > 400)
            {
                pose = prePose;
            }
        }
        public abstract void Attack(GameUnit gameUnit);
        public abstract bool Detected(GameUnit gameUnit);
        virtual public void Attacked(int hp)
        {
            hitPoint -= hp;
            if (hitPoint <= 0)
            {
                hitPoint = 0;
                unitPictureBox.Visible = false;
            }
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
