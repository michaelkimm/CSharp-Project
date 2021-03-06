using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    class GameObject
    {
        public Game game;
        protected Point pose;
        private int collisionRange;
        public GameObject(Game game)
        {
            this.game = game;
        }

        public GameObject CollisionWith(GameObject physicalObj)
        {
            if ((physicalObj.GetPose().X - this.pose.X) * (physicalObj.GetPose().X - this.pose.X) + (physicalObj.GetPose().Y - this.pose.Y) * (physicalObj.GetPose().Y - this.pose.Y) <= collisionRange * collisionRange)
                return physicalObj;

            return null;
        }

        public Point GetPose()
        {
            return pose;
        }
    }
}
