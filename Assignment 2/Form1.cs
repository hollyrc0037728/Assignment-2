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
            double R1, R2, TotalResistance;
            //Here a try-catch is set up for the imput from the textboxes 
            try
            {
                R1 = double.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("R1 has not been inputted properly");
                R1 = 0.0;
            }

            try
            {
                R2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("R2 has not been inputted properly");
                R2 = 0.0;
            }
            //calculate the values for the total resistance
            TotalResistance = R1 + R2;
            //Shoing the answer
            label11.Text = "Rt =" + TotalResistance;
        }
    }
}
