namespace Dave_Menu
{
    partial class NameNext
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
            this.btnGenerateName = new System.Windows.Forms.Button();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerateName
            // 
            this.btnGenerateName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnGenerateName.Location = new System.Drawing.Point(178, 213);
            this.btnGenerateName.Name = "btnGenerateName";
            this.btnGenerateName.Size = new System.Drawing.Size(117, 49);
            this.btnGenerateName.TabIndex = 0;
            this.btnGenerateName.Text = "Generate Name";
            this.btnGenerateName.UseVisualStyleBackColor = false;
            this.btnGenerateName.Click += new System.EventHandler(this.btnGenerateName_Click);
            // 
            // txtNewName
            // 
            this.txtNewName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.txtNewName.Location = new System.Drawing.Point(152, 166);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.ReadOnly = true;
            this.txtNewName.Size = new System.Drawing.Size(171, 20);
            this.txtNewName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 147);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // NameNext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(482, 431);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewName);
            this.Controls.Add(this.btnGenerateName);
            this.Name = "NameNext";
            this.Text = "Name Next Child";
            this.Load += new System.EventHandler(this.NameNext_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateName;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.Label label1;
    }
}