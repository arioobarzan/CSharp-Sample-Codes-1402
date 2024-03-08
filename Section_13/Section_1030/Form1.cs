using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_1030
{
    public partial class Form1 : Form
    {
        #region test1
        public Form1()
        {
            InitializeComponent();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            string msg = "Hello " + name;
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = int.Parse(textBox2.Text);
            MessageBox.Show((i * 2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = 0;
            try
            {
                num = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                textBox3.Text = "";
                return;
            }
            int f1 = 0, f2 = 1, f3 = 1;
            if (num == 1)
                MessageBox.Show("0");
            else if (num == 2)
                MessageBox.Show("1");
            else if (num > 2)
            {
                for (int i = 3; i <= num; i++)
                {
                    f3 = f2 + f1;
                    f1 = f2;
                    f2 = f3;
                }
                MessageBox.Show(f3.ToString());
            }
            else
                MessageBox.Show("Wrong input");
        }
    }
}
