namespace BMI_Calculator
{
    partial class BMICalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Imperial = new System.Windows.Forms.RadioButton();
            this.Metric = new System.Windows.Forms.RadioButton();
            this.MyHeight = new System.Windows.Forms.Label();
            this.HeightValue = new System.Windows.Forms.TextBox();
            this.MyWeight = new System.Windows.Forms.Label();
            this.WeightValue = new System.Windows.Forms.TextBox();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.BMI_Value = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Imperial
            // 
            this.Imperial.AutoSize = true;
            this.Imperial.Location = new System.Drawing.Point(12, 12);
            this.Imperial.Name = "Imperial";
            this.Imperial.Size = new System.Drawing.Size(128, 35);
            this.Imperial.TabIndex = 1;
            this.Imperial.TabStop = true;
            this.Imperial.Text = "Imperial";
            this.Imperial.UseVisualStyleBackColor = true;
            // 
            // Metric
            // 
            this.Metric.AutoSize = true;
            this.Metric.Location = new System.Drawing.Point(186, 12);
            this.Metric.Name = "Metric";
            this.Metric.Size = new System.Drawing.Size(106, 35);
            this.Metric.TabIndex = 2;
            this.Metric.TabStop = true;
            this.Metric.Text = "Metric";
            this.Metric.UseVisualStyleBackColor = true;
            // 
            // MyHeight
            // 
            this.MyHeight.AutoSize = true;
            this.MyHeight.Location = new System.Drawing.Point(14, 108);
            this.MyHeight.Name = "MyHeight";
            this.MyHeight.Size = new System.Drawing.Size(136, 31);
            this.MyHeight.TabIndex = 3;
            this.MyHeight.Text = "My Height";
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(153, 106);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(100, 38);
            this.HeightValue.TabIndex = 4;
            // 
            // MyWeight
            // 
            this.MyWeight.AutoSize = true;
            this.MyWeight.Location = new System.Drawing.Point(12, 163);
            this.MyWeight.Name = "MyWeight";
            this.MyWeight.Size = new System.Drawing.Size(141, 31);
            this.MyWeight.TabIndex = 5;
            this.MyWeight.Text = "My Weight";
            // 
            // WeightValue
            // 
            this.WeightValue.Location = new System.Drawing.Point(154, 162);
            this.WeightValue.Name = "WeightValue";
            this.WeightValue.Size = new System.Drawing.Size(100, 38);
            this.WeightValue.TabIndex = 6;
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(59, 212);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(171, 82);
            this.CalculateBMI.TabIndex = 0;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            // 
            // BMI_Value
            // 
            this.BMI_Value.Location = new System.Drawing.Point(34, 304);
            this.BMI_Value.Multiline = true;
            this.BMI_Value.Name = "BMI_Value";
            this.BMI_Value.Size = new System.Drawing.Size(220, 42);
            this.BMI_Value.TabIndex = 7;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.BMI_Value);
            this.Controls.Add(this.CalculateBMI);
            this.Controls.Add(this.Imperial);
            this.Controls.Add(this.WeightValue);
            this.Controls.Add(this.MyWeight);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this.MyHeight);
            this.Controls.Add(this.Metric);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton Imperial;
        private System.Windows.Forms.RadioButton Metric;
        private System.Windows.Forms.Label MyHeight;
        private System.Windows.Forms.TextBox HeightValue;
        private System.Windows.Forms.Label MyWeight;
        private System.Windows.Forms.TextBox WeightValue;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.TextBox BMI_Value;
    }
}

