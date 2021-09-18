namespace BeeHiveManageSystem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AssignButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.shifts = new System.Windows.Forms.NumericUpDown();
            this.WorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NextShift = new System.Windows.Forms.Button();
            this.report = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AssignButton);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.shifts);
            this.groupBox1.Controls.Add(this.WorkerBeeJob);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 119);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignment";
            // 
            // AssignButton
            // 
            this.AssignButton.Location = new System.Drawing.Point(16, 72);
            this.AssignButton.Name = "AssignButton";
            this.AssignButton.Size = new System.Drawing.Size(162, 23);
            this.AssignButton.TabIndex = 4;
            this.AssignButton.Text = "Assign this job to a bee";
            this.AssignButton.UseVisualStyleBackColor = true;
            this.AssignButton.Click += new System.EventHandler(this.AssignButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(200, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(80, 14);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Shifts";
            // 
            // shifts
            // 
            this.shifts.Location = new System.Drawing.Point(200, 40);
            this.shifts.Name = "shifts";
            this.shifts.Size = new System.Drawing.Size(69, 21);
            this.shifts.TabIndex = 2;
            this.shifts.ValueChanged += new System.EventHandler(this.shifts_ValueChanged);
            // 
            // WorkerBeeJob
            // 
            this.WorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerBeeJob.FormattingEnabled = true;
            this.WorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Egg care",
            "Hive maintenance",
            "Baby bee tutoring",
            "Honey manufacturing",
            "Sting patrol"});
            this.WorkerBeeJob.Location = new System.Drawing.Point(16, 40);
            this.WorkerBeeJob.Name = "WorkerBeeJob";
            this.WorkerBeeJob.Size = new System.Drawing.Size(162, 20);
            this.WorkerBeeJob.TabIndex = 1;
            this.WorkerBeeJob.SelectedIndexChanged += new System.EventHandler(this.WorkerBeeJob_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(16, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 14);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Worker bee job";
            // 
            // NextShift
            // 
            this.NextShift.Location = new System.Drawing.Point(323, 45);
            this.NextShift.Name = "NextShift";
            this.NextShift.Size = new System.Drawing.Size(85, 83);
            this.NextShift.TabIndex = 2;
            this.NextShift.Text = "Work the next shift";
            this.NextShift.UseVisualStyleBackColor = true;
            this.NextShift.Click += new System.EventHandler(this.NextShift_Click);
            // 
            // report
            // 
            this.report.Location = new System.Drawing.Point(26, 151);
            this.report.Multiline = true;
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(382, 189);
            this.report.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 352);
            this.Controls.Add(this.report);
            this.Controls.Add(this.NextShift);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AssignButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.NumericUpDown shifts;
        private System.Windows.Forms.ComboBox WorkerBeeJob;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button NextShift;
        private System.Windows.Forms.TextBox report;
    }
}

