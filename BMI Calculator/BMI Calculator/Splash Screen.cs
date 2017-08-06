﻿using System;
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
 * Version: 0.1
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
            try
            {
                rectangleShape3.Width += 1; // increment rectangle length
                if(rectangleShape3.Width >= 234) // when rectangle shape reaches given witdh it stop splash screen
                {
                    timer1.Stop();
                    BMICalculator bmi = new BMICalculator(); 
                    bmi.Show(); // opens BMICalculator form
                    this.Hide();
                }
            }
            catch(Exception)
            {
                return;
            }
        }

    }
}