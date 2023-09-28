using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3._2
{
    public partial class TangentForm : Form
    {
        Graphics Graph;
        Pen MyPen;

        public TangentForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
            MyPen = new Pen(Color.Black, 3);
        }

        private void TangentForm_KeyDown(object sender, KeyEventArgs e)
        {
            int x0 = ClientSize.Width / 2;
            int y0 = ClientSize.Height / 2;
            int x1, y1, x2, y2;
            double x, y;

            if(e.KeyCode == Keys.Enter)
            {
                Graph.DrawLine(MyPen, x0, 0, x0, ClientSize.Height);
                Graph.DrawLine(MyPen, 0, y0, ClientSize.Width, y0);
            }


        }
    }
}
