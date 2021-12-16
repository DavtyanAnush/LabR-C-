using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
            textBox1.Text = "-1,5";
            textBox2.Text = "-2,5";
            textBox3.Text = "-0,5";
            textBox4.Text = "-0,8";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double x0 = double.Parse(s);

            string r = textBox2.Text;
            double xk = double.Parse(r);

            string l = textBox3.Text;
            double dx = double.Parse(l);

            string chislo = textBox4.Text;
            double b = double.Parse(chislo);

            double x = x0;
            double min = (x * x) + Math.Tan(5 * x + b / x);
            double xMin = x;
            while (x>=xk)
            {
                double y = (x*x) + Math.Tan(5 * x + b / x);
                
                textBox5.Text += "x="+ x.ToString() + "\ty= " + String.Format("{0:0.###}", y) + Environment.NewLine;
                
                if (y < min)
                {
                    min = y;
                    xMin = x;
                }
                x += dx;
            }
            textBox8.Text = xMin.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double x0 = double.Parse(s);

            string r = textBox2.Text;
            double xk = double.Parse(r);

            string l = textBox3.Text;
            double dx = double.Parse(l);

            string chislo = textBox4.Text;
            double b = double.Parse(chislo);

            double x = x0;
            double pr = 1;
            do
            {
                double y = (x * x) + Math.Tan(5 * x + b / x);
                textBox6.Text += "x=" + x.ToString() + "\ty= " + String.Format("{0:0.###}", y) + Environment.NewLine;
                pr *= y;
                x += dx;                
            } while (x >= xk);
            textBox9.Text = String.Format("{0:0.###}", pr);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            double x0 = double.Parse(s);

            string r = textBox2.Text;
            double xk = double.Parse(r);

            string l = textBox3.Text;
            double dx = double.Parse(l);

            string chislo = textBox4.Text;
            double b = double.Parse(chislo);

            double sum=0;
            int i = 0;

            for(double x = x0; x >= xk; x += dx)
            {
                double y = (x * x) + Math.Tan(5 * x + b / x);
                textBox7.Text += "x=" + x.ToString() + "\ty= " + String.Format("{0:0.###}", y) + Environment.NewLine;
                if(y>=0)
                {
                    sum+= y;
                    i ++;
                }
                
            };
            if (i > 0)
            {
                double sredn = sum / i;
                textBox10.Text = String.Format("{0:0.###}", sredn);
            }
            else
            {
                textBox10.Text = "Nou";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                    e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }
    }
}
