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
 * Version: 0.7 - Added progress bar and label to display result in bmi bar
 */
namespace BMI_Calculator
{
    public partial class BMICalculator : Form
    {
                public BMICalculator()
        {
            InitializeComponent();
        }
        private double _height;
        private double _weight;
        public double _BMIResult;
        private double h;
  
        private void HeightValue_TextChanged(object sender, EventArgs e)
        {          
            //add value to textbox
            _height = double.Parse(HeightValue.Text);           
        }

        private void WeightValue_TextChanged(object sender, EventArgs e)
        {
            //add value to textbox
            _weight = double.Parse(WeightValue.Text);
        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            BMI_Value.BackColor = Color.White;
            // if radio button metric or imperial is selected then
            if (_Metric.Checked)
            {
                _Metric_CheckedChanged(sender, e);
                h = _height / 100;
                HeightValue.ReadOnly.ToString();
                WeightValue.ReadOnly.ToString();
                _BMIResult = (_weight / (h * h));
                BMI_Value.Text = _BMIResult.ToString();
                BMI_Value.BackColor = Color.White;
            }
            if (_Imperial.Checked)
            {
                _Imperial_CheckedChanged(sender, e);
                HeightValue.ReadOnly.ToString();
                WeightValue.ReadOnly.ToString();
                _BMIResult = (_weight / (_height * _height)) * 702;
                BMI_Value.Text = _BMIResult.ToString();
                BMI_Value.BackColor = Color.White;
            }
            if (_BMIResult <= 18.5)
            {
                label2.BackColor = Color.LightBlue;
                label2.Text = "UNDER WEIGHT";
                progressBar2.Value = Convert.ToInt32(_BMIResult);
                BMI_Value.BackColor = Color.LightBlue;
            }
            else if (_BMIResult <= 24.9)
            {
                label2.BackColor = Color.Green;
                label2.Text = "HEALTHY";
                progressBar2.Value = Convert.ToInt32(_BMIResult);
                BMI_Value.BackColor = Color.Green;
            }
            else if (_BMIResult <= 29.9)
            {
                label2.BackColor = Color.Orange;
                label2.Text = "OVER WEIGHT";
                progressBar2.Value = Convert.ToInt32(_BMIResult);
                BMI_Value.BackColor = Color.Orange;
            }
            else if (_BMIResult >= 30.0)
            {
                label2.BackColor = Color.Red;
                label2.Text = "OBESE";
                progressBar2.Value = Convert.ToInt32(_BMIResult);
                BMI_Value.BackColor = Color.Red;
            }
           
            progressBar2.Maximum = 40;
            progressBar2.Increment(1);
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



        private void ReSet_Click(object sender, EventArgs e)
        {
            // this method will clear values in textboxes
            Button resetButton = sender as Button; // downcasting

            switch (resetButton.Text)
            {
                case "Reset":
                    this._clear();
                    break;
            }            
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
            progressBar2.Value = 0;
            label2.Text = "BODY TYPE";
            label2.BackColor = Color.Gainsboro;
        }
        }
}
