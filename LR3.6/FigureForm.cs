using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3._6
{
    public partial class FigureForm : Form
    {
        Graphics g;
        Pen MyPen;
        SolidBrush MyBrush;
        Random Rand;
        int letter;

        public FigureForm(int key)
        {
            InitializeComponent();
            g = CreateGraphics();
            letter = key;
            Rand = new Random();
        }

        private void FigureForm_Shown(object sender, EventArgs e)
        {
            switch (letter)
            {
                case 1101:
                    {
                        Text = "Эллипс";
                        int startX = Rand.Next(0, ClientSize.Width / 2);
                        int startY = Rand.Next(0, ClientSize.Height / 2);
                        int radiusX = Rand.Next(0, ClientSize.Width);
                        int radiusY = Rand.Next(0, ClientSize.Height);
                        int borderWidth = Rand.Next(0, 30);

                        if (startX + radiusX > ClientSize.Width)
                        {
                            radiusX = ClientSize.Width - startX;
                        }
                        if (startY + radiusY > ClientSize.Height)
                        {
                            radiusY = ClientSize.Height - startY;
                        }

                        Rectangle rec = new Rectangle(startX, startY, radiusX, radiusY);

                        MyPen = new Pen(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)), borderWidth);
                        MyBrush = new SolidBrush(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)));

                        g.DrawEllipse(MyPen, rec);
                        g.FillEllipse(MyBrush, rec);
                    }
                    break;

                case 1082:
                    {
                        Text = "Квадрат";
                        int startX = Rand.Next(0, ClientSize.Width / 2);
                        int startY = Rand.Next(0, ClientSize.Height / 2);
                        int width = Rand.Next(0, ClientSize.Width / 2);
                        int height = width;
                        int borderWidth = Rand.Next(0, 30);

                        if (startX + width > ClientSize.Width)
                        {
                            width = ClientSize.Width - startX;
                        }
                        if (startY + height > ClientSize.Height)
                        {
                            height = ClientSize.Height - startY;
                        }

                        Rectangle rec = new Rectangle(startX, startY, width, height);

                        MyPen = new Pen(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)), borderWidth);
                        MyBrush = new SolidBrush(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)));

                        g.DrawRectangle(MyPen, rec);
                        g.FillRectangle(MyBrush, rec);
                    }
                    break;

                case 1090:
                    {
                        Text = "Треугольник";
                        int borderWidth = Rand.Next(0, 30);

                        Point[] trianglePoints = new Point[3];
                        for (int i = 0; i < 3; i++)
                        {
                            trianglePoints[i] = new Point(Rand.Next(0, ClientSize.Width / (i + 1)), Rand.Next(0, ClientSize.Height / (i + 1)));
                        }

                        MyPen = new Pen(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)), borderWidth);
                        MyBrush = new SolidBrush(Color.FromArgb(Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256)));

                        g.DrawPolygon(MyPen, trianglePoints);
                        g.FillPolygon(MyBrush, trianglePoints);
                    }
                    break;
            }
        }
    }
}
