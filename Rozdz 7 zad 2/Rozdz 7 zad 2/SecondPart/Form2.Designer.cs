namespace SecondPart
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
            this.exits = new System.Windows.Forms.ComboBox();
            this.goThroughTheDoor = new System.Windows.Forms.Button();
            this.goHere = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exits
            // 
            this.exits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exits.FormattingEnabled = true;
            this.exits.Location = new System.Drawing.Point(113, 179);
            this.exits.Name = "exits";
            this.exits.Size = new System.Drawing.Size(257, 21);
            this.exits.TabIndex = 7;
            // 
            // goThroughTheDoor
            // 
            this.goThroughTheDoor.Location = new System.Drawing.Point(12, 208);
            this.goThroughTheDoor.Name = "goThroughTheDoor";
            this.goThroughTheDoor.Size = new System.Drawing.Size(358, 23);
            this.goThroughTheDoor.TabIndex = 6;
            this.goThroughTheDoor.Text = "Przejdź przez drzwi";
            this.goThroughTheDoor.UseVisualStyleBackColor = true;
            this.goThroughTheDoor.Click += new System.EventHandler(this.goThroughTheDoor_Click);
            // 
            // goHere
            // 
            this.goHere.Location = new System.Drawing.Point(12, 179);
            this.goHere.Name = "goHere";
            this.goHere.Size = new System.Drawing.Size(95, 23);
            this.goHere.TabIndex = 5;
            this.goHere.Text = "Idź tam:";
            this.goHere.UseVisualStyleBackColor = true;
            this.goHere.Click += new System.EventHandler(this.goHere_Click);
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(12, 12);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(358, 161);
            this.description.TabIndex = 4;
            // 
            // check
            // 
            this.check.Location = new System.Drawing.Point(12, 237);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(358, 23);
            this.check.TabIndex = 8;
            this.check.Text = "- - - - - - - - - - - - - -";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // hide
            // 
            this.hide.Location = new System.Drawing.Point(12, 266);
            this.hide.Name = "hide";
            this.hide.Size = new System.Drawing.Size(358, 23);
            this.hide.TabIndex = 9;
            this.hide.Text = "Kryj się!";
            this.hide.UseVisualStyleBackColor = true;
            this.hide.Click += new System.EventHandler(this.hide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 294);
            this.Controls.Add(this.hide);
            this.Controls.Add(this.check);
            this.Controls.Add(this.exits);
            this.Controls.Add(this.goThroughTheDoor);
            this.Controls.Add(this.goHere);
            this.Controls.Add(this.description);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Zabawa w chowanego";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox exits;
        private System.Windows.Forms.Button goThroughTheDoor;
        private System.Windows.Forms.Button goHere;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.Button hide;
    }
}

