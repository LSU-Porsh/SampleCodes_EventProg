namespace LINQDemo
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
            this.OrigData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ArrayBtn = new System.Windows.Forms.Button();
            this.DataTableTb = new System.Windows.Forms.Button();
            this.Allbtn = new System.Windows.Forms.Button();
            this.AnyBtn = new System.Windows.Forms.Button();
            this.ContainsBtn = new System.Windows.Forms.Button();
            this.CountBtn = new System.Windows.Forms.Button();
            this.AverageBtn = new System.Windows.Forms.Button();
            this.SumBtn = new System.Windows.Forms.Button();
            this.FirstBtn = new System.Windows.Forms.Button();
            this.LastBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ConversionBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrigData)).BeginInit();
            this.SuspendLayout();
            // 
            // OrigData
            // 
            this.OrigData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrigData.Location = new System.Drawing.Point(12, 12);
            this.OrigData.Name = "OrigData";
            this.OrigData.RowHeadersWidth = 51;
            this.OrigData.RowTemplate.Height = 24;
            this.OrigData.Size = new System.Drawing.Size(508, 147);
            this.OrigData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Array Sample";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataTable Sample";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search Using LINQ";
            // 
            // SearchTb
            // 
            this.SearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.Location = new System.Drawing.Point(12, 391);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(224, 30);
            this.SearchTb.TabIndex = 2;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(275, 386);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(91, 41);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ArrayBtn
            // 
            this.ArrayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrayBtn.Location = new System.Drawing.Point(275, 200);
            this.ArrayBtn.Name = "ArrayBtn";
            this.ArrayBtn.Size = new System.Drawing.Size(91, 41);
            this.ArrayBtn.TabIndex = 3;
            this.ArrayBtn.Text = "Show";
            this.ArrayBtn.UseVisualStyleBackColor = true;
            this.ArrayBtn.Click += new System.EventHandler(this.ArrayBtn_Click);
            // 
            // DataTableTb
            // 
            this.DataTableTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataTableTb.Location = new System.Drawing.Point(275, 269);
            this.DataTableTb.Name = "DataTableTb";
            this.DataTableTb.Size = new System.Drawing.Size(91, 41);
            this.DataTableTb.TabIndex = 3;
            this.DataTableTb.Text = "Show";
            this.DataTableTb.UseVisualStyleBackColor = true;
            this.DataTableTb.Click += new System.EventHandler(this.DataTableTb_Click);
            // 
            // Allbtn
            // 
            this.Allbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Allbtn.Location = new System.Drawing.Point(868, 52);
            this.Allbtn.Name = "Allbtn";
            this.Allbtn.Size = new System.Drawing.Size(184, 89);
            this.Allbtn.TabIndex = 4;
            this.Allbtn.Text = "All()";
            this.Allbtn.UseVisualStyleBackColor = true;
            this.Allbtn.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // AnyBtn
            // 
            this.AnyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnyBtn.Location = new System.Drawing.Point(868, 166);
            this.AnyBtn.Name = "AnyBtn";
            this.AnyBtn.Size = new System.Drawing.Size(184, 89);
            this.AnyBtn.TabIndex = 4;
            this.AnyBtn.Text = "Any()";
            this.AnyBtn.UseVisualStyleBackColor = true;
            this.AnyBtn.Click += new System.EventHandler(this.AnyBtn_Click);
            // 
            // ContainsBtn
            // 
            this.ContainsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContainsBtn.Location = new System.Drawing.Point(868, 273);
            this.ContainsBtn.Name = "ContainsBtn";
            this.ContainsBtn.Size = new System.Drawing.Size(184, 89);
            this.ContainsBtn.TabIndex = 4;
            this.ContainsBtn.Text = "Contains()";
            this.ContainsBtn.UseVisualStyleBackColor = true;
            this.ContainsBtn.Click += new System.EventHandler(this.ContainsBtn_Click);
            // 
            // CountBtn
            // 
            this.CountBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountBtn.Location = new System.Drawing.Point(1076, 52);
            this.CountBtn.Name = "CountBtn";
            this.CountBtn.Size = new System.Drawing.Size(184, 89);
            this.CountBtn.TabIndex = 4;
            this.CountBtn.Text = "Count()";
            this.CountBtn.UseVisualStyleBackColor = true;
            this.CountBtn.Click += new System.EventHandler(this.CountBtn_Click);
            // 
            // AverageBtn
            // 
            this.AverageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverageBtn.Location = new System.Drawing.Point(1076, 166);
            this.AverageBtn.Name = "AverageBtn";
            this.AverageBtn.Size = new System.Drawing.Size(184, 89);
            this.AverageBtn.TabIndex = 4;
            this.AverageBtn.Text = "Average()";
            this.AverageBtn.UseVisualStyleBackColor = true;
            this.AverageBtn.Click += new System.EventHandler(this.AverageBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumBtn.Location = new System.Drawing.Point(1076, 269);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(184, 89);
            this.SumBtn.TabIndex = 4;
            this.SumBtn.Text = "Sum()";
            this.SumBtn.UseVisualStyleBackColor = true;
            // 
            // FirstBtn
            // 
            this.FirstBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstBtn.Location = new System.Drawing.Point(665, 52);
            this.FirstBtn.Name = "FirstBtn";
            this.FirstBtn.Size = new System.Drawing.Size(184, 89);
            this.FirstBtn.TabIndex = 4;
            this.FirstBtn.Text = "First()";
            this.FirstBtn.UseVisualStyleBackColor = true;
            this.FirstBtn.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // LastBtn
            // 
            this.LastBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastBtn.Location = new System.Drawing.Point(665, 147);
            this.LastBtn.Name = "LastBtn";
            this.LastBtn.Size = new System.Drawing.Size(184, 89);
            this.LastBtn.TabIndex = 4;
            this.LastBtn.Text = "Last()";
            this.LastBtn.UseVisualStyleBackColor = true;
            this.LastBtn.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(665, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 89);
            this.button3.TabIndex = 4;
            this.button3.Text = "Single";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(665, 431);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 89);
            this.button1.TabIndex = 4;
            this.button1.Text = "Union";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(665, 526);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 89);
            this.button2.TabIndex = 4;
            this.button2.Text = "Inner Join";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Allbtn_Click);
            // 
            // ConversionBtn
            // 
            this.ConversionBtn.Location = new System.Drawing.Point(27, 469);
            this.ConversionBtn.Name = "ConversionBtn";
            this.ConversionBtn.Size = new System.Drawing.Size(153, 63);
            this.ConversionBtn.TabIndex = 5;
            this.ConversionBtn.Text = "Conversion";
            this.ConversionBtn.UseVisualStyleBackColor = true;
            this.ConversionBtn.Click += new System.EventHandler(this.ConversionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 693);
            this.Controls.Add(this.ConversionBtn);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.AverageBtn);
            this.Controls.Add(this.CountBtn);
            this.Controls.Add(this.ContainsBtn);
            this.Controls.Add(this.AnyBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.LastBtn);
            this.Controls.Add(this.FirstBtn);
            this.Controls.Add(this.Allbtn);
            this.Controls.Add(this.DataTableTb);
            this.Controls.Add(this.ArrayBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.SearchTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrigData);
            this.Name = "Form1";
            this.Text = "Last()";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrigData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrigData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SearchTb;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ArrayBtn;
        private System.Windows.Forms.Button DataTableTb;
        private System.Windows.Forms.Button Allbtn;
        private System.Windows.Forms.Button AnyBtn;
        private System.Windows.Forms.Button ContainsBtn;
        private System.Windows.Forms.Button CountBtn;
        private System.Windows.Forms.Button AverageBtn;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button FirstBtn;
        private System.Windows.Forms.Button LastBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ConversionBtn;
    }
}

