using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNIT_35_ASSIGNMENT_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, R5, Resistance;

            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
            try
            {
                R5 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R5 = 0;
            }

            Resistance = R1 + R2 + R3 + R4 + R5;
            label1.Text = "Resistance =" + Resistance;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, Resistance;
            try
            {
                R1 = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                R1 = double.PositiveInfinity;
            }
            try
            {
                R2 = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                R2 = double.PositiveInfinity;
            }
            try
            {
                R3 = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                R3 = double.PositiveInfinity;
            }
            try
            {
                R4 = Convert.ToDouble(textBox9.Text);
            }
            catch
            {
                R4 = double.PositiveInfinity;

                Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
                label2.Text = "Resistance =" + Resistance;

            }
        }
    }
}
