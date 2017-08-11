using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Github link: https://github.com/sambhavkalia/BMI-Calulator
 * Name: Sambhav kalia
 * Student ID: 300900171
 * Description: This is a BMI Calculator
 * Version: 0.6 - added clear function and moved radio checked to calculateBMI method and
 *                buttons 0-9 needs to be debug.
 */
namespace BMI_Calculator
{
    public partial class BMICalculator : Form
    {
                public BMICalculator()
        {
            InitializeComponent();
        }
        private double height;
        private double weight;
        public double BMIResult;
        double h;

        private void HeightValue_TextChanged(object sender, EventArgs e)
        {
            //add value to textbox
            height = double.Parse(HeightValue.Text);           
        }

        private void WeightValue_TextChanged(object sender, EventArgs e)
        {
            //add value to textbox
            weight = double.Parse(WeightValue.Text);
        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            BMI_Value.BackColor = Color.White;
            // if radio button metric or imperial is selected then
            if (_Metric.Checked)
            {
                _Metric_CheckedChanged(sender, e);
            }
            if (_Imperial.Checked)
            {
                _Imperial_CheckedChanged(sender, e);
            }
            if (BMIResult <= 18.5)
            {
                BMI_Value.BackColor = Color.LightBlue;
            }
            else if (BMIResult <= 24.9)
            {
                BMI_Value.BackColor = Color.Green;
            }
            else if (BMIResult <= 29.9)
            {
                BMI_Value.BackColor = Color.Orange;
            }
            else if (BMIResult > 40.0)
            {
                BMI_Value.BackColor = Color.DarkRed;
            }
            if (_Metric.Checked)

            {
                h = height / 100;
                HeightValue.ReadOnly.ToString();
                WeightValue.ReadOnly.ToString();
                BMIResult = (weight / (h * h));
                BMI_Value.Text = BMIResult.ToString();
            }
            if (_Imperial.Checked)
            {
                HeightValue.ReadOnly.ToString();
                WeightValue.ReadOnly.ToString();
                BMIResult = (weight / (height * height)) * 702;
                BMI_Value.Text = BMIResult.ToString();
            }
        }

        private void BMI_Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void _Metric_CheckedChanged(object sender, EventArgs e)
        {
            // when metric checked this formula and text will change
            if (_Metric.Checked)
            cm.Text = "cm";
            kg.Text = "kg";
        }

        private void _Imperial_CheckedChanged(object sender, EventArgs e)
        {
            // when imperial checked this formula and text will change
            if (_Imperial.Checked)
            cm.Text = "inches";
            kg.Text = "lbs";
        }

        private void cm_Click(object sender, EventArgs e)
        {

        }

        private void ReSet_Click(object sender, EventArgs e)
        {
            // this method will clear values in textboxes
            _clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button calculatorButton = sender as Button; // downcasting
            if (HeightValue.Text == "0")
            {
                HeightValue.Text = calculatorButton.Text;
            }
            else
            {
                HeightValue.Text += calculatorButton.Text;
            }
            
            if (WeightValue.Text == "0")
            {
                WeightValue.Text = calculatorButton.Text;
            }
            else
            {
                WeightValue.Text += calculatorButton.Text;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button operatorButton = sender as Button; // downcasting

            switch (operatorButton.Text)
            {
                case "c":
                    this._clear();
                    break;
            }
        }
        private void _clear()
        {
            HeightValue.Text = "0";
            WeightValue.Text = "0";
            BMI_Value.Clear();
            BMI_Value.BackColor = Color.White;
        }

    }
}
