namespace Rozdz_8_zad_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "należał do gracza";
            // 
            // number
            // 
            this.number.FormattingEnabled = true;
            this.number.Location = new System.Drawing.Point(65, 15);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(54, 21);
            this.number.TabIndex = 10;
            this.number.SelectedIndexChanged += new System.EventHandler(this.number_SelectedIndexChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.nameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameLabel.Location = new System.Drawing.Point(233, 15);
            this.nameLabel.Multiline = true;
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.ReadOnly = true;
            this.nameLabel.Size = new System.Drawing.Size(100, 20);
            this.nameLabel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = ", który zakończył karierę w";
            // 
            // yearLabel
            // 
            this.yearLabel.BackColor = System.Drawing.SystemColors.Window;
            this.yearLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearLabel.Location = new System.Drawing.Point(479, 15);
            this.yearLabel.Multiline = true;
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.ReadOnly = true;
            this.yearLabel.Size = new System.Drawing.Size(52, 20);
            this.yearLabel.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(537, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "roku";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 46);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Numery koszulek sławnych zawodników";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox number;
        private System.Windows.Forms.TextBox nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearLabel;
        private System.Windows.Forms.Label label4;
    }
}

