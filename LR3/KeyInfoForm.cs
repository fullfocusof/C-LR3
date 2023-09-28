using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR3
{
    public partial class KeyInfoForm : Form
    {
        int x = 0, y = 0;
        Font MyFont = new Font("Arial", 16);
        Graphics Graph;

        string digOrLet;
        string alph = "";
        string size = "";
        char key;
        int keyCode;

        public KeyInfoForm()
        {
            InitializeComponent();
            Graph = CreateGraphics();
        }

        private void KeyInfoForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            key = e.KeyChar;
            keyCode = e.KeyChar;
            if (char.IsLetter(e.KeyChar))
            {
                digOrLet = "Буква";
                if (e.KeyChar >= 65 && e.KeyChar <= 90)
                {
                    alph = "Латинский";
                    size = "Заглавная";
                }
                else if (e.KeyChar >= 97 && e.KeyChar <= 122)
                {
                    alph = "Латинский";
                    size = "Прописная";
                }
                else if (e.KeyChar >= 1040 && e.KeyChar <= 1071)
                {
                    alph = "Русский";
                    size = "Заглавная";
                }
                else if (e.KeyChar >= 1072 && e.KeyChar <= 1103)
                {
                    alph = "Русский";
                    size = "Прописная";
                }
            }
            else if (char.IsDigit(e.KeyChar))
            {
                digOrLet = "Цифра";
            }
            else
            {
                digOrLet = "Не определено";
            }
        }

        private void KeyInfoForm_KeyUp(object sender, KeyEventArgs e)
        {
            Graph.Clear(BackColor);

            if (key != ' ')
            {
                Graph.DrawString("Клавиша - " + key, MyFont, Brushes.Black, x, y);
                Graph.DrawString("Код клавиши - " + keyCode, MyFont, Brushes.Black, x, y + 25);
                Graph.DrawString("Модификаторы - " + e.Modifiers.ToString(), MyFont, Brushes.Black, x, y + 50);
                Graph.DrawString("Вид - " + digOrLet, MyFont, Brushes.Black, x, y + 75);
                Graph.DrawString("Алфавит - " + alph, MyFont, Brushes.Black, x, y + 100);
                Graph.DrawString("Размер - " + size, MyFont, Brushes.Black, x, y + 125);
            }
            else
            {
                Graph.DrawString("Клавиша - " + e.KeyData, MyFont, Brushes.Black, x, y);
                Graph.DrawString("Код клавиши - " + keyCode, MyFont, Brushes.Black, x, y + 25);
                Graph.DrawString("Модификаторы - " + e.Modifiers.ToString(), MyFont, Brushes.Black, x, y + 50);
                Graph.DrawString("Вид - " + digOrLet, MyFont, Brushes.Black, x, y + 75);
            }

        }
    }
}
