using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Angles
    {
        public double X;
        public double Y;
        public double Z;

        public Angles()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        public static double CheckAngle(double Angle)
        {
            if (Angle > 360) return Angle - 720;
            else if (Angle < -360) return 720 + Angle;
            else return Angle;
        }
    }
}
