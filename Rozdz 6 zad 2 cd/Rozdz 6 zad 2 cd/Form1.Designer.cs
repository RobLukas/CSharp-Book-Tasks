namespace Rozdz_6_zad_2
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
            this.workerBeeJob = new System.Windows.Forms.ComboBox();
            this.nextShift = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.assignJob = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBeeJob
            // 
            this.workerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerBeeJob.FormattingEnabled = true;
            this.workerBeeJob.Items.AddRange(new object[] {
            "Nauczanie pszczółek",
            "Patrol z żądłami",
            "Pielęgnacja jaj",
            "Utrzymywanie ula",
            "Wytwarzanie miodu",
            "Zbieranie nektaru"});
            this.workerBeeJob.Location = new System.Drawing.Point(6, 34);
            this.workerBeeJob.Name = "workerBeeJob";
            this.workerBeeJob.Size = new System.Drawing.Size(153, 21);
            this.workerBeeJob.TabIndex = 0;
            // 
            // nextShift
            // 
            this.nextShift.Location = new System.Drawing.Point(301, 34);
            this.nextShift.Name = "nextShift";
            this.nextShift.Size = new System.Drawing.Size(77, 47);
            this.nextShift.TabIndex = 1;
            this.nextShift.Text = "Przepracuj następną zmianę";
            this.nextShift.UseVisualStyleBackColor = true;
            this.nextShift.Click += new System.EventHandler(this.nextShift_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.assignJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.workerBeeJob);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Przydział prac robotnicom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zmiany";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(205, 34);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(56, 20);
            this.shifts.TabIndex = 3;
            this.shifts.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // assignJob
            // 
            this.assignJob.Location = new System.Drawing.Point(6, 61);
            this.assignJob.Name = "assignJob";
            this.assignJob.Size = new System.Drawing.Size(150, 23);
            this.assignJob.TabIndex = 2;
            this.assignJob.Text = "Przypisz tę pracę pszczole";
            this.assignJob.UseVisualStyleBackColor = true;
            this.assignJob.Click += new System.EventHandler(this.assignJob_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zadanie robotnicy";
            // 
            // report
            // 
            this.report.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.report.Location = new System.Drawing.Point(12, 119);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(366, 158);
            this.report.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 289);
            this.Controls.Add(this.report);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nextShift);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "System zarządzania ulem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerBeeJob;
        private System.Windows.Forms.Button nextShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.Button assignJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox report;
    }
}

