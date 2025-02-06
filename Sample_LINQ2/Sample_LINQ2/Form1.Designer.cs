namespace LINQ_Activity
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
            this.CustomerDataGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Ans1 = new System.Windows.Forms.Button();
            this.Ans2 = new System.Windows.Forms.Button();
            this.Ans3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerDataGrid
            // 
            this.CustomerDataGrid.AllowUserToAddRows = false;
            this.CustomerDataGrid.AllowUserToDeleteRows = false;
            this.CustomerDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDataGrid.Location = new System.Drawing.Point(39, 41);
            this.CustomerDataGrid.Name = "CustomerDataGrid";
            this.CustomerDataGrid.ReadOnly = true;
            this.CustomerDataGrid.RowHeadersWidth = 51;
            this.CustomerDataGrid.RowTemplate.Height = 24;
            this.CustomerDataGrid.Size = new System.Drawing.Size(527, 331);
            this.CustomerDataGrid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of People";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ans1
            // 
            this.Ans1.Location = new System.Drawing.Point(3, 101);
            this.Ans1.Name = "Ans1";
            this.Ans1.Size = new System.Drawing.Size(160, 38);
            this.Ans1.TabIndex = 2;
            this.Ans1.Text = "List of Students";
            this.Ans1.UseVisualStyleBackColor = true;
            // 
            // Ans2
            // 
            this.Ans2.Location = new System.Drawing.Point(3, 3);
            this.Ans2.Name = "Ans2";
            this.Ans2.Size = new System.Drawing.Size(160, 38);
            this.Ans2.TabIndex = 2;
            this.Ans2.Text = "List of Adults";
            this.Ans2.UseVisualStyleBackColor = true;
            // 
            // Ans3
            // 
            this.Ans3.Location = new System.Drawing.Point(308, 388);
            this.Ans3.Name = "Ans3";
            this.Ans3.Size = new System.Drawing.Size(147, 43);
            this.Ans3.TabIndex = 2;
            this.Ans3.Text = "Search";
            this.Ans3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "List of Universities";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(39, 395);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 36);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "List of Female Students";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "List of Male Students";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 277);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 54);
            this.button4.TabIndex = 2;
            this.button4.Text = "Overall Number of Female and Male";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Ans2);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.Ans1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(572, 41);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(163, 331);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 47);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 48);
            this.button5.TabIndex = 2;
            this.button5.Text = "List of Students by University";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 510);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ans3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerDataGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ans1;
        private System.Windows.Forms.Button Ans2;
        private System.Windows.Forms.Button Ans3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button5;
    }
}

