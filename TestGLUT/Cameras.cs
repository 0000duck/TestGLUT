using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Cameras
    {
        private double x;
        private double y;
        private double z;

        private double zoom;


        public Cameras()
        {
            x = 0;
            y = 0;
            z = -7;
            zoom = 1;
        }


        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public double Z
        {
            get { return z; }
            set { z = value; }
        }
        public double Zoom
        {
            get { return zoom; }
            set
            {
                if (value < 5 && value > -5)
                    zoom = value;
            }
        }
    }
}
