using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Rotate
    {
        public int X;
        public int Y;
        public int Z;


        public Rotate ()
        {
            X = 1;
            Y = 0;
            Z = 0;
        }


        /// <summary>
        /// Выбор оси X
        /// </summary>
        public void SelectX()
        {
            X = 1;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Выбор оси Y
        /// </summary>
        public void SelectY()
        {
            X = 0;
            Y = 1;
            Z = 0;
        }

        /// <summary>
        /// Выбор оси Z
        /// </summary>
        public void SelectZ()
        {
            X = 0;
            Y = 0;
            Z = 1;
        }
    }
}
