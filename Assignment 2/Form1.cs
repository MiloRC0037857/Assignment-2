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
    }
}
