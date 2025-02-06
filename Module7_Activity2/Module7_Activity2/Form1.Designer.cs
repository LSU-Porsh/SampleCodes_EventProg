namespace Module7_Activity2
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
            this.EmployeeDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.AllStudentsBtn = new System.Windows.Forms.Button();
            this.All18StudentBtn = new System.Windows.Forms.Button();
            this.UniqueUniBtn = new System.Windows.Forms.Button();
            this.CharlieBtn = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.TotalStudentBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AllStudentLoopBtn = new System.Windows.Forms.Button();
            this.All18LoopBtn = new System.Windows.Forms.Button();
            this.AllUniquLoopBtn = new System.Windows.Forms.Button();
            this.AllCharlieLoopBtn = new System.Windows.Forms.Button();
            this.TotalStudentLoopBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDataGrid
            // 
            this.EmployeeDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGrid.Location = new System.Drawing.Point(12, 65);
            this.EmployeeDataGrid.Name = "EmployeeDataGrid";
            this.EmployeeDataGrid.RowHeadersWidth = 51;
            this.EmployeeDataGrid.RowTemplate.Height = 24;
            this.EmployeeDataGrid.Size = new System.Drawing.Size(823, 217);
            this.EmployeeDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee Info:";
            // 
            // AllStudentsBtn
            // 
            this.AllStudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStudentsBtn.Location = new System.Drawing.Point(211, 327);
            this.AllStudentsBtn.Name = "AllStudentsBtn";
            this.AllStudentsBtn.Size = new System.Drawing.Size(124, 62);
            this.AllStudentsBtn.TabIndex = 2;
            this.AllStudentsBtn.Text = "Show";
            this.AllStudentsBtn.UseVisualStyleBackColor = true;
            this.AllStudentsBtn.Click += new System.EventHandler(this.AllStudentsBtn_Click);
            // 
            // All18StudentBtn
            // 
            this.All18StudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All18StudentBtn.Location = new System.Drawing.Point(211, 395);
            this.All18StudentBtn.Name = "All18StudentBtn";
            this.All18StudentBtn.Size = new System.Drawing.Size(124, 62);
            this.All18StudentBtn.TabIndex = 2;
            this.All18StudentBtn.Text = "Show";
            this.All18StudentBtn.UseVisualStyleBackColor = true;
            this.All18StudentBtn.Click += new System.EventHandler(this.All18StudentBtn_Click);
            // 
            // UniqueUniBtn
            // 
            this.UniqueUniBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniqueUniBtn.Location = new System.Drawing.Point(211, 463);
            this.UniqueUniBtn.Name = "UniqueUniBtn";
            this.UniqueUniBtn.Size = new System.Drawing.Size(124, 62);
            this.UniqueUniBtn.TabIndex = 2;
            this.UniqueUniBtn.Text = "Show";
            this.UniqueUniBtn.UseVisualStyleBackColor = true;
            this.UniqueUniBtn.Click += new System.EventHandler(this.UniqueUniBtn_Click);
            // 
            // CharlieBtn
            // 
            this.CharlieBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharlieBtn.Location = new System.Drawing.Point(211, 531);
            this.CharlieBtn.Name = "CharlieBtn";
            this.CharlieBtn.Size = new System.Drawing.Size(124, 62);
            this.CharlieBtn.TabIndex = 2;
            this.CharlieBtn.Text = "Show";
            this.CharlieBtn.UseVisualStyleBackColor = true;
            this.CharlieBtn.Click += new System.EventHandler(this.CharlieBtn_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(416, 659);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(124, 62);
            this.SearchBtn.TabIndex = 2;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Traditional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(607, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Find all Customers that have contact no and age more than 18 years.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(273, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Retrieve all unique universities";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 531);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 60);
            this.label5.TabIndex = 3;
            this.label5.Text = "Retrieve the first name, last name, and sex from the data table \r\nwhere the first" +
    " name is ‘Charlie,’\r\nsorted in ascending order by Last name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(560, 661);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(482, 60);
            this.label6.TabIndex = 3;
            this.label6.Text = " Design a query that, given an inputted first name or last name, \r\nsearches the d" +
    "ata table and displays a row of records \r\nmatching the provided name.";
            // 
            // SearchTb
            // 
            this.SearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.Location = new System.Drawing.Point(241, 691);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(169, 30);
            this.SearchTb.TabIndex = 4;
            // 
            // TotalStudentBtn
            // 
            this.TotalStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentBtn.Location = new System.Drawing.Point(211, 599);
            this.TotalStudentBtn.Name = "TotalStudentBtn";
            this.TotalStudentBtn.Size = new System.Drawing.Size(124, 62);
            this.TotalStudentBtn.TabIndex = 2;
            this.TotalStudentBtn.Text = "Show";
            this.TotalStudentBtn.UseVisualStyleBackColor = true;
            this.TotalStudentBtn.Click += new System.EventHandler(this.TotalStudentBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(382, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Retrieve the total person that are students";
            // 
            // AllStudentLoopBtn
            // 
            this.AllStudentLoopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllStudentLoopBtn.Location = new System.Drawing.Point(55, 327);
            this.AllStudentLoopBtn.Name = "AllStudentLoopBtn";
            this.AllStudentLoopBtn.Size = new System.Drawing.Size(124, 62);
            this.AllStudentLoopBtn.TabIndex = 2;
            this.AllStudentLoopBtn.Text = "Show";
            this.AllStudentLoopBtn.UseVisualStyleBackColor = true;
            this.AllStudentLoopBtn.Click += new System.EventHandler(this.AllStudentsBtn_Click);
            // 
            // All18LoopBtn
            // 
            this.All18LoopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All18LoopBtn.Location = new System.Drawing.Point(55, 395);
            this.All18LoopBtn.Name = "All18LoopBtn";
            this.All18LoopBtn.Size = new System.Drawing.Size(124, 62);
            this.All18LoopBtn.TabIndex = 2;
            this.All18LoopBtn.Text = "Show";
            this.All18LoopBtn.UseVisualStyleBackColor = true;
            this.All18LoopBtn.Click += new System.EventHandler(this.All18StudentBtn_Click);
            // 
            // AllUniquLoopBtn
            // 
            this.AllUniquLoopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllUniquLoopBtn.Location = new System.Drawing.Point(55, 463);
            this.AllUniquLoopBtn.Name = "AllUniquLoopBtn";
            this.AllUniquLoopBtn.Size = new System.Drawing.Size(124, 62);
            this.AllUniquLoopBtn.TabIndex = 2;
            this.AllUniquLoopBtn.Text = "Show";
            this.AllUniquLoopBtn.UseVisualStyleBackColor = true;
            this.AllUniquLoopBtn.Click += new System.EventHandler(this.UniqueUniBtn_Click);
            // 
            // AllCharlieLoopBtn
            // 
            this.AllCharlieLoopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCharlieLoopBtn.Location = new System.Drawing.Point(55, 531);
            this.AllCharlieLoopBtn.Name = "AllCharlieLoopBtn";
            this.AllCharlieLoopBtn.Size = new System.Drawing.Size(124, 62);
            this.AllCharlieLoopBtn.TabIndex = 2;
            this.AllCharlieLoopBtn.Text = "Show";
            this.AllCharlieLoopBtn.UseVisualStyleBackColor = true;
            this.AllCharlieLoopBtn.Click += new System.EventHandler(this.CharlieBtn_Click);
            // 
            // TotalStudentLoopBtn
            // 
            this.TotalStudentLoopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalStudentLoopBtn.Location = new System.Drawing.Point(55, 599);
            this.TotalStudentLoopBtn.Name = "TotalStudentLoopBtn";
            this.TotalStudentLoopBtn.Size = new System.Drawing.Size(124, 62);
            this.TotalStudentLoopBtn.TabIndex = 2;
            this.TotalStudentLoopBtn.Text = "Show";
            this.TotalStudentLoopBtn.UseVisualStyleBackColor = true;
            this.TotalStudentLoopBtn.Click += new System.EventHandler(this.TotalStudentBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(223, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "LINQ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 746);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.TotalStudentLoopBtn);
            this.Controls.Add(this.AllCharlieLoopBtn);
            this.Controls.Add(this.TotalStudentBtn);
            this.Controls.Add(this.AllUniquLoopBtn);
            this.Controls.Add(this.CharlieBtn);
            this.Controls.Add(this.All18LoopBtn);
            this.Controls.Add(this.UniqueUniBtn);
            this.Controls.Add(this.AllStudentLoopBtn);
            this.Controls.Add(this.All18StudentBtn);
            this.Controls.Add(this.AllStudentsBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeeDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AllStudentsBtn;
        private System.Windows.Forms.Button All18StudentBtn;
        private System.Windows.Forms.Button UniqueUniBtn;
        private System.Windows.Forms.Button CharlieBtn;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button TotalStudentBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AllStudentLoopBtn;
        private System.Windows.Forms.Button All18LoopBtn;
        private System.Windows.Forms.Button AllUniquLoopBtn;
        private System.Windows.Forms.Button AllCharlieLoopBtn;
        private System.Windows.Forms.Button TotalStudentLoopBtn;
        private System.Windows.Forms.Label label8;
    }
}

