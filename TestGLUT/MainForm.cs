using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;
using Tao.FreeGlut;
using Tao.Platform.Windows;

namespace TestGLUT
{
    public partial class MainForm : Form
    {
        // вспомогательные переменные - в них будут храниться обработанные значения, 
        // полученные при перетаскивании ползунков пользователем 
        private Interaction Inter = new Interaction();
        private Rotate R = new Rotate();
        private Angles AutoR = new Angles();


        public MainForm()
        {
            InitializeComponent();
            AnT.InitializeContexts();
            
            AnT.MouseWheel += new MouseEventHandler(AnT_MouseWheel);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // инициализация библиотеки glut 
            Glut.glutInit();
            // инициализация режима экрана 
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);

            // установка цвета очистки экрана (RGBA) 
            Gl.glClearColor(255, 255, 255, 1);

            // установка порта вывода 
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // активация проекционной матрицы 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            // очистка матрицы 
            Gl.glLoadIdentity();

            // установка перспективы 
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // начальная настройка параметров openGL (тест глубины, освещение и первый источник света) 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);

            // установка первых элементов в списках combobox 
            ObjectComboBox.SelectedIndex = 0;

            // активация таймера, вызывающего функцию для визуализации 
            RenderTimer.Start();
        }

        // обрабатываем отклик таймера 
        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            // вызываем функцию отрисовки сцены 
            Draw();
        }
        
        // изменения значения чекбокса 
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // если отмечен 
            if (WireCheckBox.Checked)
            {
                // устанавливаем сеточный режим визуализации 
                Inter.Wire = true;
            }
            else
            {
                // иначе - полигональная визуализация 
                Inter.Wire = false;
            }
        }
        
        // функция отрисовки 
        private void Draw()
        {

            // очистка буфера цвета и буфера глубины 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glClearColor(255, 255, 255, 1);
            // очищение текущей матрицы 
            Gl.glLoadIdentity();

            // помещаем состояние матрицы в стек матриц, дальнейшие трансформации затронут только визуализацию объекта 
            Gl.glPushMatrix();
            // производим перемещение в зависимости от значений, полученных при перемещении ползунков 
            Gl.glTranslated(Inter.Camera.X, Inter.Camera.Y, Inter.Camera.Z);



            // поворот по установленной оси 
            //Gl.glRotated(Inter.Angle, Inter.Rotation.X, Inter.Rotation.Y, Inter.Rotation.Z);

            //Gl.glRotated()
            Rotating();
            AutoRotating();
            
            
            // и масштабирование объекта 
            Gl.glScaled(Inter.Camera.Zoom, Inter.Camera.Zoom, Inter.Camera.Zoom);

            // в зависимости от установленного типа объекта 
            switch (ObjectComboBox.SelectedIndex)
            {
                // рисуем нужный объект, используя функции библиотеки GLUT 
                case 0:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireSphere(2, 16, 16); // сеточная сфера 
                        else
                            Glut.glutSolidSphere(2, 16, 16); // полигональная сфера 
                        break;
                    }
                case 1:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireCylinder(1, 2, 32, 32); // цилиндр 
                        else
                            Glut.glutSolidCylinder(1, 2, 32, 32);
                        break;
                    }
                case 2:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireCube(2); // куб 
                        else
                            Glut.glutSolidCube(2);
                        break;
                    }
                case 3:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireCone(2, 3, 32, 32); // конус 
                        else
                            Glut.glutSolidCone(2, 3, 32, 32);
                        break;
                    }
                case 4:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireTorus(0.5, 1.5, 32, 32); // тор 
                        else
                            Glut.glutSolidTorus(0.5, 1.5, 32, 32);
                        break;
                    }
                case 5:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireDodecahedron(); // Додекайдер
                        else
                            Glut.glutSolidDodecahedron();
                        break;
                    }
                case 6:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireIcosahedron(); // исосахедрон
                        else
                            Glut.glutSolidIcosahedron();
                        break;
                    }
                case 7:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireOctahedron();
                        else
                            Glut.glutSolidOctahedron();
                        break;
                    }
                case 8:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireRhombicDodecahedron();
                        else
                            Glut.glutSolidRhombicDodecahedron();
                        break;
                    }
                case 9:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireSierpinskiSponge(3, new double[] { 0.0, 0.2, 0.5}, 2);
                        else
                            Glut.glutSolidSierpinskiSponge(3, new double[] { 0.0, 0.2, 0.5 }, 2);
                        break;
                    }
                case 10:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireTeapot(2); // чайник
                        else
                            Glut.glutSolidTeapot(2);
                        break;
                    }
                case 11:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWireTetrahedron(); // херня
                        else
                            Glut.glutSolidTetrahedron();
                        break;
                    }
                    /*
                case 100:
                    {
                        if (Inter.Wire) // если установлен сеточный режим визуализации 
                            Glut.glutWire; // херня
                        else
                            Glut.glutSolid;
                        break;
                    }
                    */
            }

            if (AutoRotateCheckBox.Checked)
            {
                //Inter.Angle = Inter.Angle == 360 ? -360 : Inter.Angle + 1;
                //ValueAngle.Text = Inter.Angle.ToString();
                //TrackBarAngle.Value = (int)Inter.Angle;
            }

            // возвращаем состояние матрицы 
            Gl.glPopMatrix();

            // завершаем рисование 
            Gl.glFlush();

            // обновляем элемент AnT 
            AnT.Invalidate();

        }

        
        void AnT_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta == 120)
                Inter.Camera.Zoom = Inter.Camera.Zoom - 0.1;
            else if (e.Delta == -120)
                Inter.Camera.Zoom = Inter.Camera.Zoom + 0.1;

            //TrackBarZoom.Value = (int)(Inter.Camera.Zoom * 1000);
            //ValueZoom.Text = Inter.Camera.Zoom.ToString();
            
        }

        private void AutoRotateXTrackBar_Scroll(object sender, EventArgs e)
        {
            AutoR.X = AutoRotateXTrackBar.Value;
            ValueAutoRotateXLabel.Text = AutoRotateXTrackBar.Value.ToString();
        }

        private void AutoRotateYTrackBar_Scroll(object sender, EventArgs e)
        {
            AutoR.Y = AutoRotateYTrackBar.Value;
            ValueAutoRotateYLabel.Text = AutoRotateYTrackBar.Value.ToString();
        }

        private void AutoRotateZTrackBar_Scroll(object sender, EventArgs e)
        {
            AutoR.Z = AutoRotateZTrackBar.Value;
            ValueAutoRotateZLabel.Text = AutoRotateZTrackBar.Value.ToString();
        }

        private void Rotating()
        {
            R.SelectX();
            Gl.glRotated(Inter.Angle.X, R.X, R.Y, R.Z);

            R.SelectY();
            Gl.glRotated(Inter.Angle.Y, R.X, R.Y, R.Z);

            R.SelectZ();
            Gl.glRotated(Inter.Angle.Z, R.X, R.Y, R.Z);
        }

        private void AutoRotating()
        {
            if(AutoRotateCheckBox.Checked)
            {
                Inter.Angle.X = Angles.CheckAngle(Inter.Angle.X + AutoR.X);
                ValueRotateXLabel.Text = Inter.Angle.X.ToString();
                RotateXTrackBar.Value = (int)Inter.Angle.X;

                Inter.Angle.Y = Angles.CheckAngle(Inter.Angle.Y + AutoR.Y);
                ValueRotateYLabel.Text = Inter.Angle.Y.ToString();
                RotateYTrackBar.Value = (int)Inter.Angle.Y;

                Inter.Angle.Z = Angles.CheckAngle(Inter.Angle.Z + AutoR.Z);
                ValueRotateZLabel.Text = Inter.Angle.Z.ToString();
                RotateZTrackBar.Value = (int)Inter.Angle.Z;
            }
        }

        private void RorateXTrackBar_Scroll(object sender, EventArgs e)
        {
            Inter.Angle.X = RotateXTrackBar.Value;
            ValueRotateXLabel.Text = RotateXTrackBar.Value.ToString();
        }

        private void RorateYTrackBar_Scroll(object sender, EventArgs e)
        {
            Inter.Angle.Y = RotateYTrackBar.Value;
            ValueRotateYLabel.Text = RotateYTrackBar.Value.ToString();
        }

        private void RorateZTrackBar_Scroll(object sender, EventArgs e)
        {
            Inter.Angle.Z = RotateZTrackBar.Value;
            ValueRotateZLabel.Text = RotateZTrackBar.Value.ToString();
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inter.Angle = new Angles();

            RotateXTrackBar.Value = (int)Inter.Angle.X;
            ValueRotateXLabel.Text = RotateXTrackBar.Value.ToString();

            RotateYTrackBar.Value = (int)Inter.Angle.Y;
            ValueRotateYLabel.Text = RotateYTrackBar.Value.ToString();

            RotateZTrackBar.Value = (int)Inter.Angle.Z;
            ValueRotateZLabel.Text = RotateZTrackBar.Value.ToString();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Verse.Show();
        }
    }
}
