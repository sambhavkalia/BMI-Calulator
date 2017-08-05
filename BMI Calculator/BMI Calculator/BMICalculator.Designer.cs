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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
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
            this.MyBMI = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ReSet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.78761F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.21239F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button10, 4, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 53);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 377);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(54, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 43);
            this.button2.TabIndex = 15;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(110, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 16;
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(161, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(48, 43);
            this.button4.TabIndex = 17;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(215, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(49, 43);
            this.button5.TabIndex = 18;
            this.button5.Text = "4";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 52);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 45);
            this.button6.TabIndex = 19;
            this.button6.Text = "5";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(54, 52);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 45);
            this.button7.TabIndex = 20;
            this.button7.Text = "6";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(110, 52);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(45, 45);
            this.button8.TabIndex = 21;
            this.button8.Text = "7";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(161, 52);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 45);
            this.button9.TabIndex = 22;
            this.button9.Text = "8";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(215, 52);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(49, 45);
            this.button10.TabIndex = 23;
            this.button10.Text = "9";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // _Imperial
            // 
            this._Imperial.AutoSize = true;
            this._Imperial.Location = new System.Drawing.Point(12, 21);
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
            this._Metric.Location = new System.Drawing.Point(186, 21);
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
            this._MyHeight.Location = new System.Drawing.Point(8, 180);
            this._MyHeight.Name = "_MyHeight";
            this._MyHeight.Size = new System.Drawing.Size(136, 31);
            this._MyHeight.TabIndex = 3;
            this._MyHeight.Text = "My Height";
            // 
            // HeightValue
            // 
            this.HeightValue.Location = new System.Drawing.Point(147, 177);
            this.HeightValue.Name = "HeightValue";
            this.HeightValue.Size = new System.Drawing.Size(65, 38);
            this.HeightValue.TabIndex = 4;
            this.HeightValue.TextChanged += new System.EventHandler(this.HeightValue_TextChanged);
            // 
            // _MyWeight
            // 
            this._MyWeight.AutoSize = true;
            this._MyWeight.Location = new System.Drawing.Point(3, 228);
            this._MyWeight.Name = "_MyWeight";
            this._MyWeight.Size = new System.Drawing.Size(141, 31);
            this._MyWeight.TabIndex = 5;
            this._MyWeight.Text = "My Weight";
            // 
            // WeightValue
            // 
            this.WeightValue.Location = new System.Drawing.Point(147, 226);
            this.WeightValue.Name = "WeightValue";
            this.WeightValue.Size = new System.Drawing.Size(65, 38);
            this.WeightValue.TabIndex = 6;
            this.WeightValue.TextChanged += new System.EventHandler(this.WeightValue_TextChanged);
            // 
            // CalculateBMI
            // 
            this.CalculateBMI.Location = new System.Drawing.Point(12, 326);
            this.CalculateBMI.Name = "CalculateBMI";
            this.CalculateBMI.Size = new System.Drawing.Size(145, 73);
            this.CalculateBMI.TabIndex = 0;
            this.CalculateBMI.Text = "Calculate BMI";
            this.CalculateBMI.UseVisualStyleBackColor = true;
            this.CalculateBMI.Click += new System.EventHandler(this.CalculateBMI_Click);
            // 
            // BMI_Value
            // 
            this.BMI_Value.Location = new System.Drawing.Point(147, 276);
            this.BMI_Value.Multiline = true;
            this.BMI_Value.Name = "BMI_Value";
            this.BMI_Value.Size = new System.Drawing.Size(65, 38);
            this.BMI_Value.TabIndex = 7;
            this.BMI_Value.TextChanged += new System.EventHandler(this.BMI_Value_TextChanged);
            // 
            // cm
            // 
            this.cm.AutoSize = true;
            this.cm.Location = new System.Drawing.Point(214, 181);
            this.cm.Name = "cm";
            this.cm.Size = new System.Drawing.Size(93, 31);
            this.cm.TabIndex = 8;
            this.cm.Text = "inches";
            // 
            // kg
            // 
            this.kg.AutoSize = true;
            this.kg.Location = new System.Drawing.Point(213, 231);
            this.kg.Name = "kg";
            this.kg.Size = new System.Drawing.Size(49, 31);
            this.kg.TabIndex = 0;
            this.kg.Text = "lbs";
            // 
            // MyBMI
            // 
            this.MyBMI.AutoSize = true;
            this.MyBMI.Location = new System.Drawing.Point(30, 279);
            this.MyBMI.Name = "MyBMI";
            this.MyBMI.Size = new System.Drawing.Size(98, 31);
            this.MyBMI.TabIndex = 9;
            this.MyBMI.Text = "MyBMI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 403);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 27);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ReSet
            // 
            this.ReSet.Location = new System.Drawing.Point(163, 326);
            this.ReSet.Name = "ReSet";
            this.ReSet.Size = new System.Drawing.Size(119, 72);
            this.ReSet.TabIndex = 12;
            this.ReSet.Text = "ReSet";
            this.ReSet.UseVisualStyleBackColor = true;
            this.ReSet.Click += new System.EventHandler(this.ReSet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, -4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select Mode First";
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ReSet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CalculateBMI);
            this.Controls.Add(this.MyBMI);
            this.Controls.Add(this.kg);
            this.Controls.Add(this.cm);
            this.Controls.Add(this.BMI_Value);
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
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label MyBMI;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ReSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

