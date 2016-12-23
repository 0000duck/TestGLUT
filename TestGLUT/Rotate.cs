using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGLUT
{
    class Rotate
    {
        /// <summary>
        /// Выбор плоскости для поворота
        /// </summary>

        public int X;
        public int Y;
        public int Z;


        public Rotate ()
        {
            X = 1;
            Y = 0;
            Z = 0;
        }

        public Rotate(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
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
        

        /// <summary>
        /// Выбор оси X
        /// </summary>
        public static Rotate RotateX()
        {
            return new Rotate(1, 0, 0);
        }

        /// <summary>
        /// Выбор оси Y
        /// </summary>
        public Rotate RotateY()
        {
            return new Rotate(0, 1, 0);
        }

        /// <summary>
        /// Выбор оси Z
        /// </summary>
        public Rotate RotateZ()
        {
            return new Rotate(0, 0, 1);
        }
    }
}
