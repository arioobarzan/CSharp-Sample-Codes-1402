using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Section_1530
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            name = textBox1.Text;
            string msg = "Hello " + name;
            MessageBox.Show(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox2.Text);
            MessageBox.Show((num * 2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0;
            try
            {
                x = int.Parse(textBox3.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (x == 1)
                MessageBox.Show("0");
            else if (x == 2)
                MessageBox.Show("1");
            else if (x > 2)
            {
                int f1 = 0, f2 = 1, f3 = 1;
                for (int i = 3; i <= x; i++)
                {
                    f3 = f2 + f1;
                    f1 = f2;
                    f2 = f3;
                }
                MessageBox.Show(f3.ToString());
            }
            else
                MessageBox.Show("wrong input");
        }
    }
}
