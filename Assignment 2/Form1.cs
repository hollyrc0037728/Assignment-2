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
            //This is the coding for 2 resistors in series
            double R1, R2, TotalResistance;
            //Here a try-catch is set up for the imput from the textboxes 
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R2 = 0.0;
            }
            //calculate the values for the total resistance
            TotalResistance = R1 + R2;
            //output the answer
            label11.Text = "Rt =" + TotalResistance;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //this is the coding for 2 resistors in parallel
            double R1,R2, TotalResistance;
            //here is the try-catch for the input from the textboxes
            try
            {
                R1 = double.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox4.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R2 = 0.0;
            }
            //calculate the values for total resistance
            TotalResistance = 1 / ((1 / R1) + (1 / R2));
            //Output of the answer
            label13.Text = "Rt = " + TotalResistance;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //This is the coding for 3 resistors in series
            double R1, R2, R3, TotalResistance;
            //Here is the try-catch for the input from the textboxes
            try
            {
                R1 = double.Parse(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox6.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not ben inputted properly");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox7.Text);
            }
            catch
            {
                MessageBox.Show("resistance has not been inputted properly");
                R3 = 0.0;
            }
            //calculate the total resistance
            TotalResistance = R1 + R2 + R3;
            //displaying the answer
            label12.Text = "Rt = " + TotalResistance;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //This is the coding for 3 resisitors in parallel
            double R1, R2, R3, TotalResistance;
            //Here is the try-catch for the input from the textboxes
             try
            {
                R1 = double.Parse(textBox8.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not been inputted properly");
                R1 = 0.0;
            }
            try
            {
                R2 = double.Parse(textBox9.Text);
            }
            catch
            {
                MessageBox.Show("Resistance has not ben inputted properly");
                R2 = 0.0;
            }
            try
            {
                R3 = double.Parse(textBox10.Text);
            }
            catch
            {
                MessageBox.Show("resistance has not been inputted properly");
                R3 = 0.0;
            }
            //Here is the calculation for the total resistance
            TotalResistance = 1 / ((1 / R1) + (1 / R2) + (1 / R3));
            //Displaying the answer
            label14.Text = "Rt = " + TotalResistance;
        }
    }
}
