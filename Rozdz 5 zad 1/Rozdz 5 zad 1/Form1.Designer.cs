namespace Rozdz_5_zad_1
{
    partial class Form1
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
            this.NumberOfPeopleLabel = new System.Windows.Forms.Label();
            this.NumericUpDownPeopleOfNumber = new System.Windows.Forms.NumericUpDown();
            this.FancyCheckBox = new System.Windows.Forms.CheckBox();
            this.HealthyCheckBox = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberBirthday = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.fancyBirthday = new System.Windows.Forms.CheckBox();
            this.birthdayCost = new System.Windows.Forms.Label();
            this.cakeWriting = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPeopleOfNumber)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberOfPeopleLabel
            // 
            this.NumberOfPeopleLabel.AutoSize = true;
            this.NumberOfPeopleLabel.Location = new System.Drawing.Point(6, 3);
            this.NumberOfPeopleLabel.Name = "NumberOfPeopleLabel";
            this.NumberOfPeopleLabel.Size = new System.Drawing.Size(91, 13);
            this.NumberOfPeopleLabel.TabIndex = 0;
            this.NumberOfPeopleLabel.Text = "Number of people";
            // 
            // NumericUpDownPeopleOfNumber
            // 
            this.NumericUpDownPeopleOfNumber.Location = new System.Drawing.Point(9, 19);
            this.NumericUpDownPeopleOfNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NumericUpDownPeopleOfNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownPeopleOfNumber.Name = "NumericUpDownPeopleOfNumber";
            this.NumericUpDownPeopleOfNumber.Size = new System.Drawing.Size(76, 20);
            this.NumericUpDownPeopleOfNumber.TabIndex = 1;
            this.NumericUpDownPeopleOfNumber.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NumericUpDownPeopleOfNumber.ValueChanged += new System.EventHandler(this.NumericUpDownPeopleOfNumber_ValueChanged);
            // 
            // FancyCheckBox
            // 
            this.FancyCheckBox.AutoSize = true;
            this.FancyCheckBox.Checked = true;
            this.FancyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FancyCheckBox.Location = new System.Drawing.Point(9, 46);
            this.FancyCheckBox.Name = "FancyCheckBox";
            this.FancyCheckBox.Size = new System.Drawing.Size(105, 17);
            this.FancyCheckBox.TabIndex = 2;
            this.FancyCheckBox.Text = "fancy decoration";
            this.FancyCheckBox.UseVisualStyleBackColor = true;
            this.FancyCheckBox.CheckedChanged += new System.EventHandler(this.FancyCheckBox_CheckedChanged);
            // 
            // HealthyCheckBox
            // 
            this.HealthyCheckBox.AutoSize = true;
            this.HealthyCheckBox.Location = new System.Drawing.Point(9, 69);
            this.HealthyCheckBox.Name = "HealthyCheckBox";
            this.HealthyCheckBox.Size = new System.Drawing.Size(92, 17);
            this.HealthyCheckBox.TabIndex = 3;
            this.HealthyCheckBox.Text = "healthy option";
            this.HealthyCheckBox.UseVisualStyleBackColor = true;
            this.HealthyCheckBox.CheckedChanged += new System.EventHandler(this.HealthyCheckBox_CheckedChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(6, 98);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(28, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Cost";
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(40, 97);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(70, 16);
            this.costLabel.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(274, 170);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.NumberOfPeopleLabel);
            this.tabPage1.Controls.Add(this.costLabel);
            this.tabPage1.Controls.Add(this.NumericUpDownPeopleOfNumber);
            this.tabPage1.Controls.Add(this.Label1);
            this.tabPage1.Controls.Add(this.FancyCheckBox);
            this.tabPage1.Controls.Add(this.HealthyCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(266, 144);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Other event";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cakeWriting);
            this.tabPage2.Controls.Add(this.birthdayCost);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numberBirthday);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.fancyBirthday);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(266, 144);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Birthday party";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of people";
            // 
            // numberBirthday
            // 
            this.numberBirthday.Location = new System.Drawing.Point(9, 19);
            this.numberBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numberBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberBirthday.Name = "numberBirthday";
            this.numberBirthday.Size = new System.Drawing.Size(76, 20);
            this.numberBirthday.TabIndex = 7;
            this.numberBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberBirthday.ValueChanged += new System.EventHandler(this.NumberBirthday_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Text on cake";
            // 
            // fancyBirthday
            // 
            this.fancyBirthday.AutoSize = true;
            this.fancyBirthday.Checked = true;
            this.fancyBirthday.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fancyBirthday.Location = new System.Drawing.Point(9, 46);
            this.fancyBirthday.Name = "fancyBirthday";
            this.fancyBirthday.Size = new System.Drawing.Size(105, 17);
            this.fancyBirthday.TabIndex = 8;
            this.fancyBirthday.Text = "fancy decoration";
            this.fancyBirthday.UseVisualStyleBackColor = true;
            this.fancyBirthday.CheckedChanged += new System.EventHandler(this.FancyBirthday_CheckedChanged);
            // 
            // birthdayCost
            // 
            this.birthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.birthdayCost.Location = new System.Drawing.Point(40, 115);
            this.birthdayCost.Name = "birthdayCost";
            this.birthdayCost.Size = new System.Drawing.Size(70, 16);
            this.birthdayCost.TabIndex = 13;
            this.birthdayCost.Text = "pln";
            // 
            // cakeWriting
            // 
            this.cakeWriting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cakeWriting.Location = new System.Drawing.Point(9, 88);
            this.cakeWriting.Name = "cakeWriting";
            this.cakeWriting.Size = new System.Drawing.Size(144, 16);
            this.cakeWriting.TabIndex = 14;
            this.cakeWriting.Text = "Happy birthday!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 183);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPeopleOfNumber)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NumberOfPeopleLabel;
        private System.Windows.Forms.NumericUpDown NumericUpDownPeopleOfNumber;
        private System.Windows.Forms.CheckBox FancyCheckBox;
        private System.Windows.Forms.CheckBox HealthyCheckBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numberBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox fancyBirthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cakeWriting;
        private System.Windows.Forms.Label birthdayCost;
    }
}

