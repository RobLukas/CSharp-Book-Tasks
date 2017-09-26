namespace Rozdz_2_zad_6
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.joeCash = new System.Windows.Forms.Label();
            this.bobCash = new System.Windows.Forms.Label();
            this.bankCash = new System.Windows.Forms.Label();
            this.joeGivesToBob = new System.Windows.Forms.Button();
            this.bobGivesToJoe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Daj 10zł Joemu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "Weź 5zł od Boba";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // joeCash
            // 
            this.joeCash.AutoSize = true;
            this.joeCash.Location = new System.Drawing.Point(30, 16);
            this.joeCash.Name = "joeCash";
            this.joeCash.Size = new System.Drawing.Size(76, 13);
            this.joeCash.TabIndex = 2;
            this.joeCash.Text = "Joe have 50 zl";
            // 
            // bobCash
            // 
            this.bobCash.AutoSize = true;
            this.bobCash.Location = new System.Drawing.Point(30, 38);
            this.bobCash.Name = "bobCash";
            this.bobCash.Size = new System.Drawing.Size(84, 13);
            this.bobCash.TabIndex = 3;
            this.bobCash.Text = "Bob have 100 zl";
            // 
            // bankCash
            // 
            this.bankCash.AutoSize = true;
            this.bankCash.Location = new System.Drawing.Point(30, 61);
            this.bankCash.Name = "bankCash";
            this.bankCash.Size = new System.Drawing.Size(90, 13);
            this.bankCash.TabIndex = 4;
            this.bankCash.Text = "Bank have 100 zl";
            // 
            // joeGivesToBob
            // 
            this.joeGivesToBob.Location = new System.Drawing.Point(12, 157);
            this.joeGivesToBob.Name = "joeGivesToBob";
            this.joeGivesToBob.Size = new System.Drawing.Size(94, 49);
            this.joeGivesToBob.TabIndex = 5;
            this.joeGivesToBob.Text = "Joe give 10 zl to Bob";
            this.joeGivesToBob.UseVisualStyleBackColor = true;
            this.joeGivesToBob.Click += new System.EventHandler(this.joeGivesToBob_Click);
            // 
            // bobGivesToJoe
            // 
            this.bobGivesToJoe.Location = new System.Drawing.Point(113, 157);
            this.bobGivesToJoe.Name = "bobGivesToJoe";
            this.bobGivesToJoe.Size = new System.Drawing.Size(94, 49);
            this.bobGivesToJoe.TabIndex = 6;
            this.bobGivesToJoe.Text = "Bob give 5 zl to Joe";
            this.bobGivesToJoe.UseVisualStyleBackColor = true;
            this.bobGivesToJoe.Click += new System.EventHandler(this.bobGivesToJoe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 218);
            this.Controls.Add(this.bobGivesToJoe);
            this.Controls.Add(this.joeGivesToBob);
            this.Controls.Add(this.bankCash);
            this.Controls.Add(this.bobCash);
            this.Controls.Add(this.joeCash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label joeCash;
        private System.Windows.Forms.Label bobCash;
        private System.Windows.Forms.Label bankCash;
        private System.Windows.Forms.Button joeGivesToBob;
        private System.Windows.Forms.Button bobGivesToJoe;
    }
}

