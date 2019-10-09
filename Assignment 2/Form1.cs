using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double r1;

            try
            {
                r1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r1 = 0.0;
            }
            double r2;

            try
            {
                r2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r2 = 0.0;
            }

            double tot1 = r1 + r2;
            label1.Text = "Total Resistance = " + tot1 + " Ω";
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double r3;

            try
            {
                r3 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r3 = 0.0;
            }
            double r4;

            try
            {
                r4 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r4 = 0.0;
            }

            double tot2 = (1 / ((1.0 / r3) + (1.0 / r4)));
            label2.Text = "Total Resistance = " + tot2 + " Ω";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double r5;

            try
            {
                r5 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r5 = 0.0;
            }
            double r6;

            try
            {
                r6 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r6 = 0.0;
            }

            double r7;

            try
            {
                r7 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r7 = 0.0;
            }

            double tot3 = r5 + r6+ r7;
            label3.Text = "Total Resistance = " + tot3 + " Ω";
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double r8;

            try
            {
                r8 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r8 = 0.0;
            }
            double r9;

            try
            {
                r9 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r9 = 0.0;
            }

            double r10;

            try
            {
                r10 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("Not a correct value.");
                r10 = 0.0;
            }

            double tot4 = (1 / ((1.0 / r8) + ((1.0 / r9) + (1.0 / r10))));
            double tot4 = tot4.ToString("N3");
            label4.Text = "Total Resistance = " + tot4 + " Ω";
        }
    }
}
