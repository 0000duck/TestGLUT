using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Interaction
    {
        public Cameras Camera;
        public Rotate Rotation;
        public double Angle;
        public bool Wire;

        public Interaction()
        {
            Camera = new Cameras();
            Rotation = new Rotate();
            Angle = 0;
            Wire = false;
        }
    }
}
