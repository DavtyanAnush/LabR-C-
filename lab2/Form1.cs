using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Введите возраст (полных лет)";
            textBox2.Text = "Введите рост (см)";
            comboBox1.Text = "Выберите тип телосложения";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Visible= true;
            string v = textBox1.Text;
            int age = int.Parse(v);
            
            string r = textBox2.Text;
            int growth= int.Parse(r);
            double ves = 0;

            if(age>=40)
                switch (comboBox1.SelectedIndex)
                {
                    case (0):
                        if (rButtonZ.Checked)
                            ves = ((growth - 100) * 0.9) * 0.9;
                        else if (rButtonM.Checked)
                            ves = ((growth - 100) * 0.9) * 0.9;
                        break;
                    case (1):
                        if (rButtonZ.Checked)
                            ves = (growth - 100) * 0.9;
                        else if (rButtonM.Checked)
                            ves = (growth - 100) * 0.9;
                        break;
                    case (2):
                        if (rButtonZ.Checked)
                            ves = (growth - 100) * 1.1;
                        else if (rButtonM.Checked)
                            ves = (growth - 100) * 1.1;
                        break;
                }
            else
                switch (comboBox1.SelectedIndex)
                {
                    case (0):
                        if (rButtonZ.Checked)
                            ves = ((growth - 110) * 0.9) * 0.9;
                        else if (rButtonM.Checked)
                            ves = ((growth - 110) * 0.9) * 0.9;
                        break;
                    case (1):
                        if (rButtonZ.Checked)
                            ves = (growth - 110) * 0.9;
                        else if (rButtonM.Checked)
                            ves = (growth - 110) * 0.9;
                        break;
                    case (2):
                        if (rButtonZ.Checked)
                            ves = (growth - 110) * 1.1;
                        else if (rButtonM.Checked)
                            ves = (growth - 110) * 1.1;
                        break;
                }

            label9.Text = ves.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Три основных типа телосложения:\n " +
                "-Астенический(длинная и тонкая шея, узкие плечи, плоская и узкая грудная клетка, длинные руки и ноги, вытянутое лицо, тонкий нос, мышцы развиты слабо, склонность к полноте минимальна);\n" +
                "-Нормостенический(стройные ноги, тонкая талия, гармоничная фигура, обычно рост средний);\n" +
                "-Гиперстенический(тяжелые и широкие кости, объемные плечи, широкая и короткая грудная клетка, чуть укороченные руки и ноги, рост, как правило, ниже среднего, высокая склонность к полноте).");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if((e.KeyChar <= 47 || e.KeyChar >= 58)&&(n!=8)&& (n != 44)&& (n != 45))
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char n = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (n != 8) && (n != 44) && (n != 45))
                e.Handled = true;
        }
    }
}
