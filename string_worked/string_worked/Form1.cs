using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_worked
{
    public partial class Form1 : Form
    {
        String str = "Hello, How are you? This is My project";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var fs = File.Create("234.txt");
            fs.Close();
            File.WriteAllText("234.txt", str);
            File.AppendAllText("234.txt", str);

            #region File
            //var fs = File.Create("123.txt");
            //fs.Close();
            //File.WriteAllText("123.txt",str);
            //File.AppendAllText("123.txt",str);
            #endregion
            //csv
            #region String Works

            //MessageBox.Show(str.Length.ToString());
            //str = str.Substring(8,2);
            //str = str.Trim();
            //MessageBox.Show(str.EndsWith("ct").ToString());
            //MessageBox.Show(str.StartsWith("Th").ToString());
            //MessageBox.Show(str.Contains("Pro").ToString());
            //str = str.ToUpper();
            //str = str.ToLower();
            //str = str.Replace("my","your");
            //str = str.Substring(0, 7) + str.Substring(10);
            //var i  = str.IndexOf("m");
            //str = str.Substring(i);
            //int i = str.IndexOf("my");
            //str = str.Substring(i);
            //int j = str.Length-4;
            //str = str.Substring(j);
            //str = str.PadLeft(30, '#');
            //str = str.PadRight(30, '#');
            //var s = str.Split(' ');
            //for (int i = 0; i < s.Length; i++)
                //MessageBox.Show(s[i]);
            //str = str.TrimEnd();

            //label1.Text = "--------" + str + "-----";
            #endregion

        }
    }
}
