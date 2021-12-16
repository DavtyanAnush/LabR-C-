using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] A = {"1110111", "10101000", "010111", "10111" };
            listBox1.Items.Clear();
            for (int i = 0; i < A.Length; i++)
            {
                listBox1.Items.Add(A[i]);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBox1.Text;
            int x = int.Parse(s);
            int r = 0;
            while (x>0)
            {
                if ((x % 10) == 1)
                {
                  r = (r* 10)+1;
                }
                    
                x = x / 10;
            }
            textBox1.Text = r.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
