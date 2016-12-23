using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Interaction
    {
        public Cameras Camera;
        public Rotate Rotation;
        //public double Angle;
        public Angles Angle;
        public bool Wire;

        public Interaction()
        {
            Camera = new Cameras();
            Rotation = new Rotate();
            Angle = new Angles();
            Wire = false;
        }
    }
}
