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
 * Name: Sambhav kalia
 * Student ID: 300900171
 * Description: This is a BMI Calculator
 * Version: 0.2
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

        private void HeightValue_TextChanged(object sender, EventArgs e)
        {
            //add value to textbox
            height = Convert.ToDouble(HeightValue.Text);
        }

        private void WeightValue_TextChanged(object sender, EventArgs e)
        {
            //add value to textbox
            weight = Convert.ToDouble(WeightValue.Text);
        }

        private void CalculateBMI_Click(object sender, EventArgs e)
        {
            // if radio button metric or imperial is selected then
            if (_Metric.Checked)
            {
                _Metric_CheckedChanged(sender, e);
            }
            if(_Imperial.Checked)
            {
                _Imperial_CheckedChanged(sender,e);
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
            HeightValue.ReadOnly.ToString();
            WeightValue.ReadOnly.ToString();
            BMIResult = (weight / (height /100 * height));
            BMI_Value.Text = BMIResult.ToString();
        }

        private void _Imperial_CheckedChanged(object sender, EventArgs e)
        {
            // when imperial checked this formula and text will change
            if (_Imperial.Checked)
            cm.Text = "inches";
            kg.Text = "lbs";
            HeightValue.ReadOnly.ToString();
            WeightValue.ReadOnly.ToString();
            BMIResult = (weight / (height * height))*702;
            BMI_Value.Text = BMIResult.ToString();
        }

        private void cm_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            // this method will clesr values in textboxes
            HeightValue.Clear();
            WeightValue.Clear();
            BMI_Value.Text = "";
        }


    }
}
