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
            this._Imperial = new System.Windows.Forms.RadioButton();
            this._Metric = new System.Windows.Forms.RadioButton();
            this._MyHeight = new System.Windows.Forms.Label();
            this.HeightValue = new System.Windows.Forms.TextBox();
            this._MyWeight = new System.Windows.Forms.Label();
            this.WeightValue = new System.Windows.Forms.TextBox();
            this.CalculateBMI = new System.Windows.Forms.Button();
            this.BMI_Value = new System.Windows.Forms.TextBox();
            this.cm = new System.Windows.Forms.Label();
            this.kg = new System.Windows.Forms.Label();
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
            // _Imperial
            // 
            this._Imperial.AutoSize = true;
            this._Imperial.Location = new System.Drawing.Point(12, 12);
            this._Imperial.Name = "_Imperial";
            this._Imperial.Size = new System.Drawing.Size(128, 35);
            this._Imperial.TabIndex = 1;
            this._Imperial.TabStop = true;
            this._Imperial.Text = "Imperial";
            this._Imperial.UseVisualStyleBackColor = true;
            this._Imperial.CheckedChanged += new System.EventHandler(this._Imperial_CheckedChanged);
            // 
            // _Metric
            // 
            this._Metric.AutoSize = true;
            this._Metric.Location = new System.Drawing.Point(186, 12);
            this._Metric.Name = "_Metric";
            this._Metric.Size = new System.Drawing.Size(106, 35);
            this._Metric.TabIndex = 2;
            this._Metric.TabStop = true;
            this._Metric.Text = "Metric";
            this._Metric.UseVisualStyleBackColor = true;
            this._Metric.CheckedChanged += new System.EventHandler(this._Metric_CheckedChanged);
            // 
            // _MyHeight
            // 
            this._MyHeight.AutoSize = true;
            this._MyHeight.Location = new System.Drawing.Point(14, 108);
            this._MyHeight.Name = "_MyHeight";
            this._MyHeight.Size = new System.Drawing.Size(136, 31);
            this._MyHeight.TabIndex = 3;
            this._MyHeight.Text = "My Height";
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(153, 106);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(65, 38);
            this.HeightValue.TabIndex = 4;
            this.HeightValue.TextChanged += new System.EventHandler(this.HeightValue_TextChanged);
            // 
            // _MyWeight
            // 
            this._MyWeight.AutoSize = true;
            this._MyWeight.Location = new System.Drawing.Point(12, 163);
            this._MyWeight.Name = "_MyWeight";
            this._MyWeight.Size = new System.Drawing.Size(141, 31);
            this._MyWeight.TabIndex = 5;
            this._MyWeight.Text = "My Weight";
            // 
            // WeightValue
            // 
            this.WeightValue.Location = new System.Drawing.Point(154, 162);
            this.WeightValue.Name = "WeightValue";
            this.WeightValue.Size = new System.Drawing.Size(64, 38);
            this.WeightValue.TabIndex = 6;
            this.WeightValue.TextChanged += new System.EventHandler(this.WeightValue_TextChanged);
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(59, 212);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(171, 82);
            this.CalculateBMI.TabIndex = 0;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // BMI_Value
            // 
            this.BMI_Value.Location = new System.Drawing.Point(34, 304);
            this.BMI_Value.Multiline = true;
            this.BMI_Value.Name = "BMI_Value";
            this.BMI_Value.Size = new System.Drawing.Size(220, 42);
            this.BMI_Value.TabIndex = 7;
            this.BMI_Value.TextChanged += new System.EventHandler(this.BMI_Value_TextChanged);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(216, 110);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(93, 31);
            this.cm.TabIndex = 8;
            this.cm.Text = "inches";
            this.cm.Click += new System.EventHandler(this.cm_Click);
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(216, 166);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(49, 31);
            this.kg.TabIndex = 0;
            this.kg.Text = "lbs";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.BMI_Value);
            this.Controls.Add(this.CalculateBMI);
            this.Controls.Add(this._Imperial);
            this.Controls.Add(this.WeightValue);
            this.Controls.Add(this._MyWeight);
            this.Controls.Add(this.HeightValue);
            this.Controls.Add(this._MyHeight);
            this.Controls.Add(this._Metric);
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
        private System.Windows.Forms.RadioButton _Imperial;
        private System.Windows.Forms.RadioButton _Metric;
        private System.Windows.Forms.Label _MyHeight;
        private System.Windows.Forms.TextBox HeightValue;
        private System.Windows.Forms.Label _MyWeight;
        private System.Windows.Forms.TextBox WeightValue;
        private System.Windows.Forms.Button CalculateBMI;
        private System.Windows.Forms.TextBox BMI_Value;
        private System.Windows.Forms.Label cm;
        private System.Windows.Forms.Label kg;
    }
}

