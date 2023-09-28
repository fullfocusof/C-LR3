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
    public partial class ThreeFigureForm : Form
    {
        Graphics g;
        Font MyFont = new Font("Times New Roman", 32);
        int key;

        public ThreeFigureForm()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        private void ThreeFigureForm_Shown(object sender, EventArgs e)
        {
            g.DrawString("Нажмите:\n <э> для генерации эллипса \n <к> для генерации квадрата \n <т> для генерации треугольника \n\n ESC для закрытия приложения", MyFont, Brushes.Black, ClientSize.Width/2 - 300, ClientSize.Height/2 - 150);
        }

        private void ThreeFigureForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 27)
            {
                Close();
            }
            else
            {
                key = e.KeyChar;
                FigureForm figure = new FigureForm(key);
                figure.Show();
            }
        }

        private void ThreeFigureForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите закрыть приложение?", "Закрытие приложения", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
