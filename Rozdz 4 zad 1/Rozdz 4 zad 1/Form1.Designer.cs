namespace Rozdz_4_zad_1
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
            this.numberEnd = new System.Windows.Forms.NumericUpDown();
            this.numberStart = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EndLabel = new System.Windows.Forms.Label();
            this.StartLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStart)).BeginInit();
            this.SuspendLayout();
            // 
            // numberEnd
            // 
            this.numberEnd.Location = new System.Drawing.Point(207, 67);
            this.numberEnd.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numberEnd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberEnd.Name = "numberEnd";
            this.numberEnd.Size = new System.Drawing.Size(120, 22);
            this.numberEnd.TabIndex = 20;
            this.numberEnd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberStart
            // 
            this.numberStart.Location = new System.Drawing.Point(207, 31);
            this.numberStart.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numberStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberStart.Name = "numberStart";
            this.numberStart.Size = new System.Drawing.Size(120, 22);
            this.numberStart.TabIndex = 19;
            this.numberStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(190, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pieniadze do zwrotu";
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(12, 67);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(145, 17);
            this.EndLabel.TabIndex = 16;
            this.EndLabel.Text = "Końcowy stan licznika";
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(12, 36);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(164, 17);
            this.StartLabel.TabIndex = 15;
            this.StartLabel.Text = "Początkowy start licznika";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(120, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 32);
            this.button1.TabIndex = 14;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 220);
            this.Controls.Add(this.numberEnd);
            this.Controls.Add(this.numberStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EndLabel);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberStart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberEnd;
        private System.Windows.Forms.NumericUpDown numberStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button button1;
    }
}

