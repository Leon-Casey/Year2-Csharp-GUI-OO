namespace Dave_Menu
{
    partial class display6
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
            this.monthly_allowence = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.return2main = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthly_allowence
            // 
            this.monthly_allowence.Location = new System.Drawing.Point(148, 196);
            this.monthly_allowence.Name = "monthly_allowence";
            this.monthly_allowence.Size = new System.Drawing.Size(158, 52);
            this.monthly_allowence.TabIndex = 0;
            this.monthly_allowence.Text = "Calculate Monthly Allowence";
            this.monthly_allowence.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 1;
            // 
            // return2main
            // 
            this.return2main.Location = new System.Drawing.Point(148, 282);
            this.return2main.Name = "return2main";
            this.return2main.Size = new System.Drawing.Size(158, 44);
            this.return2main.TabIndex = 26;
            this.return2main.Text = "Return to main form";
            this.return2main.UseVisualStyleBackColor = true;
            this.return2main.Click += new System.EventHandler(this.return2main_Click);
            // 
            // display6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(458, 430);
            this.Controls.Add(this.return2main);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthly_allowence);
            this.Name = "display6";
            this.Text = "display6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button monthly_allowence;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button return2main;
    }
}