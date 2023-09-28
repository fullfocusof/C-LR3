using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3._4
{
    public partial class AutoScaleForm : Form
    {
        int top, left, width, height;
        Graphics g;
        SolidBrush MyBrush = new SolidBrush(Color.Red);

        public AutoScaleForm()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void AutoScaleForm_Paint(object sender, PaintEventArgs e)
        {
            g.FillEllipse(MyBrush, ClientSize.Width / 2 - 15, ClientSize.Height / 2 - 15, 30, 30);
        }

        private void AutoScaleForm_Resize(object sender, EventArgs e)
        {
            width = ClientSize.Width; 
            height = ClientSize.Height;
            Text = width + " x " + height + " x: " + Top + " y: " + Left;
            Refresh();
        }

        private void AutoScaleForm_Load(object sender, EventArgs e)
        {
            Text = width + " x " + height + " x: " + Top + " y: " + Left;
        }

        private void AutoScaleForm_Move(object sender, EventArgs e)
        {
            top = Top;
            left = Left;
            Text = width + " x " + height + " x: " + Top + " y: " + Left;
        }
    }
}
