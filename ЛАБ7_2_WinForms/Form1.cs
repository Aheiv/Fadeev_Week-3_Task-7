using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБ7_2_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int counter = 0;
            bool b = false;
            foreach (string item in str.Split(new Char[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries))
            {
                b = false;
                foreach (char ch in item)
                    if (char.IsUpper(ch))
                        b = true;
                    else
                    {
                        b = false;
                        break;
                    }
                if (b) counter++;
            }
            textBox2.Text = counter.ToString();
        }
    }
}
