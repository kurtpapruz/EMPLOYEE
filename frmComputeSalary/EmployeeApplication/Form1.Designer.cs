namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.FnameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.DepBox = new System.Windows.Forms.TextBox();
            this.JobBox = new System.Windows.Forms.TextBox();
            this.Department = new System.Windows.Forms.Label();
            this.JobTitle = new System.Windows.Forms.Label();
            this.RateBox = new System.Windows.Forms.TextBox();
            this.TotalWorkedBox = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.Label();
            this.TotalHours = new System.Windows.Forms.Label();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FnameBox
            // 
            this.FnameBox.Location = new System.Drawing.Point(32, 64);
            this.FnameBox.Name = "FnameBox";
            this.FnameBox.Size = new System.Drawing.Size(224, 20);
            this.FnameBox.TabIndex = 0;
            // 
            // LNameBox
            // 
            this.LNameBox.Location = new System.Drawing.Point(293, 64);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(224, 20);
            this.LNameBox.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(29, 29);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(81, 18);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "FirstName:";
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName.Location = new System.Drawing.Point(290, 31);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(80, 18);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "LastName:";
            // 
            // DepBox
            // 
            this.DepBox.Location = new System.Drawing.Point(32, 148);
            this.DepBox.Name = "DepBox";
            this.DepBox.Size = new System.Drawing.Size(224, 20);
            this.DepBox.TabIndex = 4;
            // 
            // JobBox
            // 
            this.JobBox.Location = new System.Drawing.Point(293, 148);
            this.JobBox.Name = "JobBox";
            this.JobBox.Size = new System.Drawing.Size(224, 20);
            this.JobBox.TabIndex = 5;
            // 
            // Department
            // 
            this.Department.AutoSize = true;
            this.Department.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.Location = new System.Drawing.Point(29, 117);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(89, 18);
            this.Department.TabIndex = 6;
            this.Department.Text = "Department:";
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSize = true;
            this.JobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitle.Location = new System.Drawing.Point(290, 117);
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Size = new System.Drawing.Size(68, 18);
            this.JobTitle.TabIndex = 7;
            this.JobTitle.Text = "Job Title:";
            // 
            // RateBox
            // 
            this.RateBox.Location = new System.Drawing.Point(32, 240);
            this.RateBox.Name = "RateBox";
            this.RateBox.Size = new System.Drawing.Size(224, 20);
            this.RateBox.TabIndex = 8;
            // 
            // TotalWorkedBox
            // 
            this.TotalWorkedBox.Location = new System.Drawing.Point(293, 240);
            this.TotalWorkedBox.Name = "TotalWorkedBox";
            this.TotalWorkedBox.Size = new System.Drawing.Size(224, 20);
            this.TotalWorkedBox.TabIndex = 9;
            // 
            // Rate
            // 
            this.Rate.AutoSize = true;
            this.Rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rate.Location = new System.Drawing.Point(29, 210);
            this.Rate.Name = "Rate";
            this.Rate.Size = new System.Drawing.Size(105, 18);
            this.Rate.TabIndex = 10;
            this.Rate.Text = "Rate per Hour:";
            // 
            // TotalHours
            // 
            this.TotalHours.AutoSize = true;
            this.TotalHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHours.Location = new System.Drawing.Point(290, 210);
            this.TotalHours.Name = "TotalHours";
            this.TotalHours.Size = new System.Drawing.Size(147, 18);
            this.TotalHours.TabIndex = 11;
            this.TotalHours.Text = "Total Hours Worked:";
            // 
            // ComputeButton
            // 
            this.ComputeButton.Location = new System.Drawing.Point(210, 280);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(102, 31);
            this.ComputeButton.TabIndex = 12;
            this.ComputeButton.Text = "Compute Salary";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Location = new System.Drawing.Point(29, 358);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(35, 13);
            this.Result.TabIndex = 13;
            this.Result.Text = "label1";
            
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(534, 484);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.TotalHours);
            this.Controls.Add(this.Rate);
            this.Controls.Add(this.TotalWorkedBox);
            this.Controls.Add(this.RateBox);
            this.Controls.Add(this.JobTitle);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.JobBox);
            this.Controls.Add(this.DepBox);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FnameBox);
            this.Name = "frmComputeSalary";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FnameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.TextBox DepBox;
        private System.Windows.Forms.TextBox JobBox;
        private System.Windows.Forms.Label Department;
        private System.Windows.Forms.Label JobTitle;
        private System.Windows.Forms.TextBox RateBox;
        private System.Windows.Forms.TextBox TotalWorkedBox;
        private System.Windows.Forms.Label Rate;
        private System.Windows.Forms.Label TotalHours;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label Result;
    }
}

