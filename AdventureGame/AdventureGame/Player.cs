﻿using System;
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

        public Player(PictureBox pictureBox, Label label, Point pose, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, pose, speed, initialHitPoint, initialMp, power, detectLength)
        {

        }

        public Player(PictureBox pictureBox, Label label, int x, int y, int speed, int initialHitPoint, int initialMp, int power, int detectLength)
            : base(pictureBox, label, x, y, speed, initialHitPoint, initialMp, power, detectLength)
        {

        }

        public override bool Detected(GameUnit gameUnit)
        {
            if (!(gameUnit is Enemy))
                return false;

            Enemy enemy = gameUnit as Enemy;
            if ((enemy.Pose.X - this.Pose.X) * (enemy.Pose.X - this.Pose.X) + (enemy.Pose.Y - this.Pose.Y) * (enemy.Pose.Y - this.Pose.Y) <= detectLength * detectLength)
                return true;
            else
                return false;
        }

        public override void Attack(GameUnit gameUnit)
        {
            if (!(gameUnit is Enemy))
                return;

            if (IsDead) return;
            if (gameUnit.IsDead) return;

            Enemy enemy = gameUnit as Enemy;
            enemy.Attacked(power);
        }

        public void equip(Weapon weapon)
        {
            // 이전 장착된 것 해제
            equipments.UnitPictureBox.BorderStyle = BorderStyle.None;

            // 새로 장착
            equipments = weapon;
            equipments.UnitPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
