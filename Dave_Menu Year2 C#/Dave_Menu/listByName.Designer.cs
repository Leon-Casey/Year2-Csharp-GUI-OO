﻿namespace Dave_Menu
{
    partial class listByName
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
            this.return2main = new System.Windows.Forms.Button();
            this.listViewAge = new System.Windows.Forms.ListView();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // return2main
            // 
            this.return2main.Location = new System.Drawing.Point(233, 561);
            this.return2main.Name = "return2main";
            this.return2main.Size = new System.Drawing.Size(163, 44);
            this.return2main.TabIndex = 1;
            this.return2main.Text = "Return to main form";
            this.return2main.UseVisualStyleBackColor = true;
            this.return2main.Click += new System.EventHandler(this.return2main_Click);
            // 
            // listViewAge
            // 
            this.listViewAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.listViewAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewAge.GridLines = true;
            this.listViewAge.Location = new System.Drawing.Point(86, 12);
            this.listViewAge.Name = "listViewAge";
            this.listViewAge.Size = new System.Drawing.Size(450, 435);
            this.listViewAge.TabIndex = 18;
            this.listViewAge.UseCompatibleStateImageBehavior = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(229, 479);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 44);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listByName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(608, 535);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.listViewAge);
            this.Controls.Add(this.return2main);
            this.Name = "listByName";
            this.Text = "Alphabetical Order";
            this.Load += new System.EventHandler(this.listByName_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button return2main;
        private System.Windows.Forms.ListView listViewAge;
        private System.Windows.Forms.Button btnBack;
    }
}