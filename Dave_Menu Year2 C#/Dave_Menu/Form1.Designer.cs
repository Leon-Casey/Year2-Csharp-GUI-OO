namespace Dave_Menu
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
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnBirthdays = new System.Windows.Forms.Button();
            this.btnListByAge = new System.Windows.Forms.Button();
            this.btnAlphabetical = new System.Windows.Forms.Button();
            this.btnMultiBirths = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnNameNext = new System.Windows.Forms.Button();
            this.btnMonthlyAllowance = new System.Windows.Forms.Button();
            this.btnAnnualAllowance = new System.Windows.Forms.Button();
            this.btnSchoolTimes = new System.Windows.Forms.Button();
            this.btnInfoGraphic = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.results = new System.Windows.Forms.ListBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(502, 28);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(288, 52);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload Data ";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnBirthdays
            // 
            this.btnBirthdays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnBirthdays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBirthdays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBirthdays.Location = new System.Drawing.Point(502, 84);
            this.btnBirthdays.Name = "btnBirthdays";
            this.btnBirthdays.Size = new System.Drawing.Size(288, 52);
            this.btnBirthdays.TabIndex = 1;
            this.btnBirthdays.Text = "Birthdays";
            this.btnBirthdays.UseVisualStyleBackColor = false;
            this.btnBirthdays.Click += new System.EventHandler(this.btnBirthdays_Click);
            // 
            // btnListByAge
            // 
            this.btnListByAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnListByAge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListByAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListByAge.Location = new System.Drawing.Point(502, 142);
            this.btnListByAge.Name = "btnListByAge";
            this.btnListByAge.Size = new System.Drawing.Size(288, 47);
            this.btnListByAge.TabIndex = 2;
            this.btnListByAge.Text = "List children by age";
            this.btnListByAge.UseVisualStyleBackColor = false;
            this.btnListByAge.Click += new System.EventHandler(this.btnListByAge_Click);
            // 
            // btnAlphabetical
            // 
            this.btnAlphabetical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnAlphabetical.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlphabetical.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphabetical.Location = new System.Drawing.Point(502, 195);
            this.btnAlphabetical.Name = "btnAlphabetical";
            this.btnAlphabetical.Size = new System.Drawing.Size(288, 49);
            this.btnAlphabetical.TabIndex = 3;
            this.btnAlphabetical.Text = "List children in alphabetical order";
            this.btnAlphabetical.UseVisualStyleBackColor = false;
            this.btnAlphabetical.Click += new System.EventHandler(this.btnAlphabetical_Click);
            // 
            // btnMultiBirths
            // 
            this.btnMultiBirths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnMultiBirths.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMultiBirths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiBirths.Location = new System.Drawing.Point(502, 250);
            this.btnMultiBirths.Name = "btnMultiBirths";
            this.btnMultiBirths.Size = new System.Drawing.Size(288, 52);
            this.btnMultiBirths.TabIndex = 4;
            this.btnMultiBirths.Text = "List all multiple births";
            this.btnMultiBirths.UseVisualStyleBackColor = false;
            this.btnMultiBirths.Click += new System.EventHandler(this.btnMultiBirths_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnAddChild.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChild.Location = new System.Drawing.Point(502, 308);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(288, 52);
            this.btnAddChild.TabIndex = 5;
            this.btnAddChild.Text = "Add new child ";
            this.btnAddChild.UseVisualStyleBackColor = false;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnNameNext
            // 
            this.btnNameNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnNameNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNameNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNameNext.Location = new System.Drawing.Point(502, 366);
            this.btnNameNext.Name = "btnNameNext";
            this.btnNameNext.Size = new System.Drawing.Size(288, 47);
            this.btnNameNext.TabIndex = 6;
            this.btnNameNext.Text = "Name the next baby";
            this.btnNameNext.UseVisualStyleBackColor = false;
            this.btnNameNext.Click += new System.EventHandler(this.btnNameNext_Click);
            // 
            // btnMonthlyAllowance
            // 
            this.btnMonthlyAllowance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnMonthlyAllowance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonthlyAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlyAllowance.Location = new System.Drawing.Point(502, 419);
            this.btnMonthlyAllowance.Name = "btnMonthlyAllowance";
            this.btnMonthlyAllowance.Size = new System.Drawing.Size(288, 50);
            this.btnMonthlyAllowance.TabIndex = 7;
            this.btnMonthlyAllowance.Text = "Calculate Mrs. McCaves childrens allowance for the current month.";
            this.btnMonthlyAllowance.UseVisualStyleBackColor = false;
            this.btnMonthlyAllowance.Click += new System.EventHandler(this.btnMonthlyAllowance_Click);
            // 
            // btnAnnualAllowance
            // 
            this.btnAnnualAllowance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnAnnualAllowance.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnnualAllowance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnualAllowance.Location = new System.Drawing.Point(502, 475);
            this.btnAnnualAllowance.Name = "btnAnnualAllowance";
            this.btnAnnualAllowance.Size = new System.Drawing.Size(288, 53);
            this.btnAnnualAllowance.TabIndex = 8;
            this.btnAnnualAllowance.Text = "Calculate Mrs. McCaves childrens allowance for the year";
            this.btnAnnualAllowance.UseVisualStyleBackColor = false;
            this.btnAnnualAllowance.Click += new System.EventHandler(this.btnAnnualAllowance_Click);
            // 
            // btnSchoolTimes
            // 
            this.btnSchoolTimes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnSchoolTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchoolTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchoolTimes.Location = new System.Drawing.Point(502, 534);
            this.btnSchoolTimes.Name = "btnSchoolTimes";
            this.btnSchoolTimes.Size = new System.Drawing.Size(288, 44);
            this.btnSchoolTimes.TabIndex = 9;
            this.btnSchoolTimes.Text = "Planning school times";
            this.btnSchoolTimes.UseVisualStyleBackColor = false;
            this.btnSchoolTimes.Click += new System.EventHandler(this.btnSchoolTimes_Click);
            // 
            // btnInfoGraphic
            // 
            this.btnInfoGraphic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnInfoGraphic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfoGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoGraphic.Location = new System.Drawing.Point(502, 584);
            this.btnInfoGraphic.Name = "btnInfoGraphic";
            this.btnInfoGraphic.Size = new System.Drawing.Size(288, 59);
            this.btnInfoGraphic.TabIndex = 10;
            this.btnInfoGraphic.Text = "Produce a dynamic info graphic of the McCave family ";
            this.btnInfoGraphic.UseVisualStyleBackColor = false;
            this.btnInfoGraphic.Click += new System.EventHandler(this.btnInfoGraphic_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(206, 256);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(8, 20);
            this.textBox2.TabIndex = 12;
            // 
            // results
            // 
            this.results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.results.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.ForeColor = System.Drawing.SystemColors.WindowText;
            this.results.FormattingEnabled = true;
            this.results.ItemHeight = 18;
            this.results.Location = new System.Drawing.Point(12, 28);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(402, 612);
            this.results.TabIndex = 13;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(235)))), ((int)(((byte)(201)))));
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(12, 646);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(209)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(802, 678);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.results);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnInfoGraphic);
            this.Controls.Add(this.btnSchoolTimes);
            this.Controls.Add(this.btnAnnualAllowance);
            this.Controls.Add(this.btnMonthlyAllowance);
            this.Controls.Add(this.btnNameNext);
            this.Controls.Add(this.btnAddChild);
            this.Controls.Add(this.btnMultiBirths);
            this.Controls.Add(this.btnAlphabetical);
            this.Controls.Add(this.btnListByAge);
            this.Controls.Add(this.btnBirthdays);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnBirthdays;
        private System.Windows.Forms.Button btnListByAge;
        private System.Windows.Forms.Button btnAlphabetical;
        private System.Windows.Forms.Button btnMultiBirths;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnNameNext;
        private System.Windows.Forms.Button btnMonthlyAllowance;
        private System.Windows.Forms.Button btnAnnualAllowance;
        private System.Windows.Forms.Button btnSchoolTimes;
        private System.Windows.Forms.Button btnInfoGraphic;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.ListBox results;
    }
}

