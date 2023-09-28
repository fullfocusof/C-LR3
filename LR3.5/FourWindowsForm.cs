using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3._5
{
    public partial class FourWindowsForm : Form
    {
        int cntWindows;

        public FourWindowsForm()
        {
            InitializeComponent();
            cntWindows++;
        }

        private void FourWindowsForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 49)
            {
                OpenMultipleWindows(1);
            }
            else if (e.KeyChar == 50)
            {
                OpenMultipleWindows(2);
            }
            else if (e.KeyChar == 51)
            {
                OpenMultipleWindows(3);
            }
            else if (e.KeyChar == 52)
            {
                OpenMultipleWindows(4);
            }
        }

        private void OpenMultipleWindows(int numOfWindows)
        {
            for (int i = 0; i < numOfWindows; i++)
            {
                FourWindowsForm newWindow = new FourWindowsForm();
                cntWindows++;
                newWindow.Text = "Окно " + cntWindows;
                newWindow.Show();
            }
        }
    }
}
