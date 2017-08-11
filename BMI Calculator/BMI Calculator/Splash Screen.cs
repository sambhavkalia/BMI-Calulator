using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Github link: https://github.com/sambhavkalia/BMI-Calulator
 * Name: Sambhav kalia
 * Student ID: 300900171
 * Description: This is a Splash Screen for BMI Calculator
 * Version: 0.3 -  made progress bar running using if statement
 */

namespace BMI_Calculator
{
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Increment(1);
            progressBar1.Maximum = 274; // maximum value dor progress bar to reach
            if (progressBar1.Value == 274) // when progress bar reaches given value it stop splash screen
            {
                timer1.Stop(); // stop timer
                BMICalculator bmi = new BMICalculator();
                bmi.Show(); // opens BMICalculator form
                this.Hide();
            }
        }

    }
}
