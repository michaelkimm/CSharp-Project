using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    interface IPhysics
    {
        IPhysics CollisionWith(IPhysics physicalObj);
        Point GetPose();
    }
}
