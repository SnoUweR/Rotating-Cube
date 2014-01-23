using System;
using System.Drawing;
using System.Windows.Forms;
using RotatingIsometricCube.Properties;

/*
 * Вращающийся куб (Rotating Cube)
 * Copyright (c) 2013 Vladislav «SnoUweR» Kovalev at http://me.snouwer.ru

 * Данная лицензия разрешает лицам, получившим копию данного программного обеспечения и сопутствующей документации (в дальнейшем именуемыми "Программное Обеспечение"), безвозмездно использовать Программное Обеспечение без ограничений,
 * включая неограниченное право на использование, изменение, добавление, публикацию, распространение, также как и лицам, которым предоставляется данное Программное Обеспечение, при соблюдении следующих условий:
 * 
 * Вышеупомянутый копирайт и данные условия должны быть включены во все копии или значимые части данного Программного Обеспечения.
 * 
 * ДАННОЕ ПРОГРАММНОЕ ОБЕСПЕЧЕНИЕ ПРЕДОСТАВЛЯЕТСЯ «КАК ЕСТЬ», БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ, ЯВНО ВЫРАЖЕННЫХ ИЛИ ПОДРАЗУМЕВАЕМЫХ, ВКЛЮЧАЯ, НО НЕ ОГРАНИЧИВАЯСЬ ГАРАНТИЯМИ ТОВАРНОЙ ПРИГОДНОСТИ, СООТВЕТСТВИЯ ПО ЕГО КОНКРЕТНОМУ НАЗНАЧЕНИЮ И НЕ НАРУШЕНИЯ ПРАВ.
 * НИ В КАКОМ СЛУЧАЕ АВТОРЫ ИЛИ ПРАВООБЛАДАТЕЛИ НЕ НЕСУТ ОТВЕТСТВЕННОСТИ ПО ИСКАМ О ВОЗМЕЩЕНИИ УЩЕРБА, УБЫТКОВ ИЛИ ДРУГИХ ТРЕБОВАНИЙ ПО ДЕЙСТВУЮЩИМ КОНТРАКТАМ, ДЕЛИКТАМ ИЛИ ИНОМУ, ВОЗНИКШИМ ИЗ, ИМЕЮЩИМ ПРИЧИНОЙ ИЛИ СВЯЗАННЫМ С ПРОГРАММНЫМ ОБЕСПЕЧЕНИЕМ ИЛИ ИСПОЛЬЗОВАНИЕМ ПРОГРАММНОГО ОБЕСПЕЧЕНИЯ ИЛИ ИНЫМИ ДЕЙСТВИЯМИ С ПРОГРАММНЫМ ОБЕСПЕЧЕНИЕМ.
 */


namespace RotatingIsometricCube
{
    public partial class Form1 : Form
    {
        #region Объявление и инициализация переменных

        private const double Angle = Math.PI*90/180.0;
        // https://ru.wikipedia.org/wiki/Матрица_поворота
        private readonly float[,] _iso =
        {
            //Матрица проекции в изометрию
            {(float) Math.Cos(Math.PI/6), (float) Math.Cos(Math.PI/6), 0, 0},
            {-(float) Math.Sin(Math.PI/6), (float) Math.Sin(Math.PI/6), 1, 0},
            {0, 0, 0, 0},
            {0, 0, 0, 1}
        };

        private readonly int _xOrigin;
        private readonly int _yOrigin;

        private float[,] A;
        private float[,] A1;
        private float[,] A1I;
        private float[,] A1R;
        private float[,] AI;
        private float[,] AR;
        private float[,] B;
        private float[,] B1;
        private float[,] B1I;
        private float[,] B1R;
        private float[,] BI;
        private float[,] BR;
        private float[,] C;
        private float[,] C1;
        private float[,] C1I;
        private float[,] C1R;
        private float[,] CI;
        private float[,] CR;
        private float[,] D;
        private float[,] D1;
        private float[,] D1I;
        private float[,] D1R;
        private float[,] DI;
        private float[,] DR;

        private float[,] _rotateMatrix =
        {
            //Матрица вращения вокруг оси Z
            {(float) Math.Cos(Angle), -(float) Math.Sin(Angle), 0, 0},
            {(float) Math.Sin(Angle), (float) Math.Cos(Angle), 0, 0},
            {0, 0, 1, 0},
            {0, 0, 0, 1}
        };

        private int _animSpeed = 1;
        private double _curDeg = 90;
        private int _degrees = 90;
        private int _depth = 100;

        private Bitmap _drawArea;
        private Graphics _g;
        private int _height = 100;

        private bool _isBackward;

        private bool _isClicking;

        private int _rotateType = 3;
        private int _width = 100;

        //Вершины куба после проекции (те, что с I) и вращения (те, что с R)

        #endregion

        public Form1()
        {
            InitializeComponent();
            _xOrigin = pictureBox1.Width/2 - 90;
            _yOrigin = pictureBox1.Height/2 - 40;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _drawArea = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            _g = Graphics.FromImage(_drawArea);
            _g.Clear(Color.White);
            widthUpDown.Value = _width;
            heightUpDown.Value = _height;
            depthUpDown.Value = _depth;
            Clear();
            Redraw();
            label7.Text += Resources.BuildDate;
        }

        #region Основные методы

        private void Redraw()
        {
            Clear();
            _g.Clear(Color.White);

            Draw(_g, _xOrigin, _yOrigin);
            DrawXYZ(new Point(_xOrigin + 87, _yOrigin + 50));
            pictureBox1.Image = _drawArea;
            label5.Text = "Угол: " + _curDeg + "°";
        }

        /// <summary>
        ///     Создает матрицу поворота и вращает по ней куб
        /// </summary>
        /// <param name="deg">Градус, на который поворачивать</param>
        private void CreateNewRtt(double deg)
        {
            _curDeg = deg;
            double angle = Math.PI*_curDeg/180.0;
            switch (_rotateType)
            {
                case 3:
                    _rotateMatrix = new[,]
                    {
                        //Матрица вращения вокруг оси Z
                        {(float) Math.Cos(angle), -(float) Math.Sin(angle), 0, 0},
                        {(float) Math.Sin(angle), (float) Math.Cos(angle), 0, 0},
                        {0, 0, 1, 0},
                        {0, 0, 0, 1}
                    };
                    break;
                case 2:
                    _rotateMatrix = new[,]
                    {
                        //Матрица вращения вокруг оси Y
                        {(float) Math.Cos(angle), 0, (float) Math.Sin(angle), 0},
                        {0, 1, 0, 0},
                        {-(float) Math.Sin(angle), 0, (float) Math.Cos(angle), 0},
                        {0, 0, 0, 1}
                    };
                    break;
                case 1:
                    _rotateMatrix = new[,]
                    {
                        //Матрица вращения вокруг оси X
                        {1, 0, 0, 0},
                        {0, (float) Math.Cos(angle), -(float) Math.Sin(angle), 0},
                        {0, (float) Math.Sin(angle), (float) Math.Cos(angle), 0},
                        {0, 0, 0, 1}
                    };
                    break;
            }
            Redraw();
        }

        public void Draw(Graphics g, int xOrigin, int yOrigin)
        {
            //Умножение матриц координат на матрицы преобразований
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        AR[i, j] += _rotateMatrix[i, k]*A[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        BR[i, j] += _rotateMatrix[i, k]*B[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        CR[i, j] += _rotateMatrix[i, k]*C[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        DR[i, j] += _rotateMatrix[i, k]*D[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        A1R[i, j] += _rotateMatrix[i, k]*A1[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        B1R[i, j] += _rotateMatrix[i, k]*B1[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        C1R[i, j] += _rotateMatrix[i, k]*C1[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        D1R[i, j] += _rotateMatrix[i, k]*D1[k, j];
                    }
                }
            } //Здесь заканчивается вращение куба
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        AI[i, j] += _iso[i, k]*AR[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        BI[i, j] += _iso[i, k]*BR[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        CI[i, j] += _iso[i, k]*CR[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        DI[i, j] += _iso[i, k]*DR[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        A1I[i, j] += _iso[i, k]*A1R[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        B1I[i, j] += _iso[i, k]*B1R[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        C1I[i, j] += _iso[i, k]*C1R[k, j];
                    }
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    for (int k = 0; k < 4; k++)
                    {
                        D1I[i, j] += _iso[i, k]*D1R[k, j];
                    }
                }
            } //А здесь заканчивается проекция


            if (_rotateType == 1)
            {
                xOrigin = xOrigin + 87 - 50 - 37;
                yOrigin = yOrigin - 50 + 100 + 50;
            }
            else
            {
                xOrigin = xOrigin + 87;
                yOrigin = yOrigin - 50 + 100;
            }
            var pencil = new Pen(Color.Black, 1f);
            var ap = new PointF(AI[0, 0] + xOrigin, AI[1, 0] + yOrigin); //Задаю точки для рисования куба
            var bp = new PointF(BI[0, 0] + xOrigin, BI[1, 0] + yOrigin);
            var cp = new PointF(CI[0, 0] + xOrigin, CI[1, 0] + yOrigin);
            var dp = new PointF(DI[0, 0] + xOrigin, DI[1, 0] + yOrigin);
            var a1P = new PointF(A1I[0, 0] + xOrigin, A1I[1, 0] + yOrigin);
            var b1P = new PointF(B1I[0, 0] + xOrigin, B1I[1, 0] + yOrigin);
            var c1P = new PointF(C1I[0, 0] + xOrigin, C1I[1, 0] + yOrigin);
            var d1P = new PointF(D1I[0, 0] + xOrigin, D1I[1, 0] + yOrigin);
            g.DrawLine(pencil, ap, bp); //Рисую куб
            g.DrawLine(pencil, ap, cp);
            g.DrawLine(pencil, cp, dp);
            g.DrawLine(pencil, dp, bp);
            g.DrawLine(pencil, ap, a1P);
            g.DrawLine(pencil, b1P, bp);
            g.DrawLine(pencil, c1P, cp);
            g.DrawLine(pencil, d1P, dp);
            g.DrawLine(pencil, a1P, b1P);
            g.DrawLine(pencil, a1P, c1P);
            g.DrawLine(pencil, d1P, c1P);
            g.DrawLine(pencil, d1P, b1P);
        }

        private void DrawXYZ(Point origin)
        {
            var fromPoint = new Point(origin.X, origin.Y);

            //Z
            var toPoint = new Point(origin.X, origin.Y - 200);
            _g.DrawLine(new Pen(Color.Blue), fromPoint, toPoint);

            //Рисуем стрелки к оси Z
            _g.DrawLine(new Pen(Color.Blue), toPoint, new Point(toPoint.X + 4, toPoint.Y + 8));
            _g.DrawLine(new Pen(Color.Blue), toPoint, new Point(toPoint.X - 4, toPoint.Y + 8));

            label10.Location = new Point(toPoint.X + 10, toPoint.Y);
            label10.Visible = true;

            //Y
            toPoint = new Point(origin.X + 300, origin.Y + 173);
            _g.DrawLine(new Pen(Color.Red), fromPoint, toPoint);


            //Рисуем стрелки к оси Y
            _g.DrawLine(new Pen(Color.Red), toPoint, new Point(toPoint.X - 4, toPoint.Y - 8));
            _g.DrawLine(new Pen(Color.Red), toPoint, new Point(toPoint.X - 8, toPoint.Y + 2));

            label9.Location = new Point(toPoint.X + 10, toPoint.Y);
            label9.Visible = true;

            //X
            toPoint = new Point(origin.X - 300, origin.Y + 173);
            _g.DrawLine(new Pen(Color.Green), fromPoint, toPoint);


            //Рисуем стрелки к оси X
            _g.DrawLine(new Pen(Color.Green), toPoint, new Point(toPoint.X + 4, toPoint.Y - 8));
            _g.DrawLine(new Pen(Color.Green), toPoint, new Point(toPoint.X + 8, toPoint.Y + 2));

            label8.Location = new Point(toPoint.X - 10, toPoint.Y);
            label8.Visible = true;
        }

        private void Clear()
        {
            A = new float[,] {{0}, {0}, {-_height}, {1}};
            B = new float[,] {{_width}, {0}, {-_height}, {1}};
            C = new float[,] {{0}, {_depth}, {-_height}, {1}};
            D = new float[,] {{_width}, {_depth}, {-_height}, {1}};
            A1 = new float[,] {{0}, {0}, {0}, {1}};
            B1 = new float[,] {{_width}, {0}, {0}, {1}};
            C1 = new float[,] {{0}, {_depth}, {0}, {1}};
            D1 = new float[,] {{_width}, {_depth}, {0}, {1}}; //Координаты вершин куба в 3D

            AI = new float[4, 1];
            BI = new float[4, 1];
            CI = new float[4, 1];
            DI = new float[4, 1];
            A1I = new float[4, 1];
            B1I = new float[4, 1];
            C1I = new float[4, 1];
            D1I = new float[4, 1];
            AR = new float[4, 1];
            BR = new float[4, 1];
            CR = new float[4, 1];
            DR = new float[4, 1];
            A1R = new float[4, 1];
            B1R = new float[4, 1];
            C1R = new float[4, 1];
            D1R = new float[4, 1];
        }

        #endregion

        #region Эвенты контролов

        private void playAnimBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            playAnimBtn.Text = timer1.Enabled ? ";" : "4";
        }

        private void nextStepBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            playAnimBtn.Text = "4";
            CreateNewRtt(_curDeg + 1);
        }

        private void previousStepBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            playAnimBtn.Text = "4";
            CreateNewRtt(_curDeg - 1);
        }

        private void forwardAnimBtn_Click(object sender, EventArgs e)
        {
            _isBackward = false;
            timer1.Enabled = true;
            playAnimBtn.Text = ";";
        }

        private void backwardAnimBtn_Click(object sender, EventArgs e)
        {
            _isBackward = true;
            timer1.Enabled = true;
            playAnimBtn.Text = ";";
        }

        private void heightUpDown_ValueChanged(object sender, EventArgs e)
        {
            _height = (int) heightUpDown.Value;
            Redraw();
        }

        private void depthUpDown_ValueChanged(object sender, EventArgs e)
        {
            _depth = (int) depthUpDown.Value;
            Redraw();
        }

        private void widthUpDown_ValueChanged(object sender, EventArgs e)
        {
            _width = (int) widthUpDown.Value;
            Redraw();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label4.Text = "X: " + e.X + " Y: " + e.Y;

            if (_isClicking)
            {
                CreateNewRtt(e.X);
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label4.Text = "X: 0 Y: 0";
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isClicking = true;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            _isClicking = false;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            playAnimBtn.Text = "4";
            speedUpDown.Value = _animSpeed = 1;
            _degrees = 90;
            CreateNewRtt(90);
            widthUpDown.Value = _width = 100;
            heightUpDown.Value = _height = 100;
            depthUpDown.Value = _depth = 100;
            zRadioBtn.Checked = true;
            _rotateType = 3;
        }

        private void speedUpDown_ValueChanged(object sender, EventArgs e)
        {
            _animSpeed = (int) speedUpDown.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_isBackward)
            {
                if (_degrees - _animSpeed > 0)
                {
                    _degrees -= _animSpeed;
                }
                else _degrees = 360;
            }
            else
            {
                if (_degrees + _animSpeed < 360)
                {
                    _degrees += _animSpeed;
                }
                else _degrees = 0;
            }
            CreateNewRtt(_degrees);
        }

        private void zRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (zRadioBtn.Checked) _rotateType = 3;
        }

        private void yRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (yRadioBtn.Checked) _rotateType = 2;
        }

        private void xRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (xRadioBtn.Checked) _rotateType = 1;
        }

        #endregion
    }
}