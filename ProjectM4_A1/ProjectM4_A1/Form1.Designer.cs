namespace ProjectM4_A1
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
            this.components = new System.ComponentModel.Container();
            this.PIdlbl = new System.Windows.Forms.Label();
            this.ItemDeslbl = new System.Windows.Forms.Label();
            this.ProNamelbl = new System.Windows.Forms.Label();
            this.ItemDestb = new System.Windows.Forms.RichTextBox();
            this.ProNametb = new System.Windows.Forms.TextBox();
            this.PIDtb = new System.Windows.Forms.TextBox();
            this.CategoryCombo = new System.Windows.Forms.ComboBox();
            this.CatLbl = new System.Windows.Forms.Label();
            this.AddCatbtn = new System.Windows.Forms.Button();
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddProbtn = new System.Windows.Forms.Button();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.SubMenuDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SubMenuDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // PIdlbl
            // 
            this.PIdlbl.AutoSize = true;
            this.PIdlbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIdlbl.Location = new System.Drawing.Point(59, 22);
            this.PIdlbl.Name = "PIdlbl";
            this.PIdlbl.Size = new System.Drawing.Size(102, 22);
            this.PIdlbl.TabIndex = 1;
            this.PIdlbl.Text = "Product ID:";
            // 
            // ItemDeslbl
            // 
            this.ItemDeslbl.AutoSize = true;
            this.ItemDeslbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDeslbl.Location = new System.Drawing.Point(516, 22);
            this.ItemDeslbl.Name = "ItemDeslbl";
            this.ItemDeslbl.Size = new System.Drawing.Size(148, 22);
            this.ItemDeslbl.TabIndex = 1;
            this.ItemDeslbl.Text = "Item Description:";
            // 
            // ProNamelbl
            // 
            this.ProNamelbl.AutoSize = true;
            this.ProNamelbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNamelbl.Location = new System.Drawing.Point(33, 62);
            this.ProNamelbl.Name = "ProNamelbl";
            this.ProNamelbl.Size = new System.Drawing.Size(128, 22);
            this.ProNamelbl.TabIndex = 1;
            this.ProNamelbl.Text = "Product Name:";
            // 
            // ItemDestb
            // 
            this.ItemDestb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemDestb.Location = new System.Drawing.Point(670, 22);
            this.ItemDestb.Name = "ItemDestb";
            this.ItemDestb.Size = new System.Drawing.Size(300, 134);
            this.ItemDestb.TabIndex = 2;
            this.ItemDestb.Text = "";
            // 
            // ProNametb
            // 
            this.ProNametb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProNametb.Location = new System.Drawing.Point(167, 58);
            this.ProNametb.Name = "ProNametb";
            this.ProNametb.Size = new System.Drawing.Size(294, 28);
            this.ProNametb.TabIndex = 3;
            // 
            // PIDtb
            // 
            this.PIDtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIDtb.Location = new System.Drawing.Point(167, 22);
            this.PIDtb.Name = "PIDtb";
            this.PIDtb.Size = new System.Drawing.Size(98, 28);
            this.PIDtb.TabIndex = 4;
            // 
            // CategoryCombo
            // 
            this.CategoryCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCombo.FormattingEnabled = true;
            this.CategoryCombo.Location = new System.Drawing.Point(167, 92);
            this.CategoryCombo.Name = "CategoryCombo";
            this.CategoryCombo.Size = new System.Drawing.Size(150, 30);
            this.CategoryCombo.TabIndex = 5;
            this.CategoryCombo.TextChanged += new System.EventHandler(this.CategoryCombo_TextChanged);
            // 
            // CatLbl
            // 
            this.CatLbl.AutoSize = true;
            this.CatLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatLbl.Location = new System.Drawing.Point(74, 100);
            this.CatLbl.Name = "CatLbl";
            this.CatLbl.Size = new System.Drawing.Size(87, 22);
            this.CatLbl.TabIndex = 6;
            this.CatLbl.Text = "Category:";
            // 
            // AddCatbtn
            // 
            this.AddCatbtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCatbtn.Location = new System.Drawing.Point(323, 93);
            this.AddCatbtn.Name = "AddCatbtn";
            this.AddCatbtn.Size = new System.Drawing.Size(102, 29);
            this.AddCatbtn.TabIndex = 7;
            this.AddCatbtn.Text = "Add";
            this.AddCatbtn.UseVisualStyleBackColor = true;
            this.AddCatbtn.Click += new System.EventHandler(this.AddCatbtn_Click);
            // 
            // ProductGridView
            // 
            this.ProductGridView.AllowUserToAddRows = false;
            this.ProductGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.GridColor = System.Drawing.Color.Peru;
            this.ProductGridView.Location = new System.Drawing.Point(284, 175);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 51;
            this.ProductGridView.RowTemplate.Height = 24;
            this.ProductGridView.Size = new System.Drawing.Size(686, 334);
            this.ProductGridView.TabIndex = 8;
            this.ProductGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellClick);
            this.ProductGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductGridView_CellMouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.UpdateBtn);
            this.panel2.Controls.Add(this.AddProbtn);
            this.panel2.Controls.Add(this.ProductGridView);
            this.panel2.Controls.Add(this.AddCatbtn);
            this.panel2.Controls.Add(this.CatLbl);
            this.panel2.Controls.Add(this.CategoryCombo);
            this.panel2.Controls.Add(this.PriceTb);
            this.panel2.Controls.Add(this.PIDtb);
            this.panel2.Controls.Add(this.ProNametb);
            this.panel2.Controls.Add(this.ItemDestb);
            this.panel2.Controls.Add(this.PriceLbl);
            this.panel2.Controls.Add(this.ProNamelbl);
            this.panel2.Controls.Add(this.ItemDeslbl);
            this.panel2.Controls.Add(this.PIdlbl);
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 560);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteBtn.Location = new System.Drawing.Point(101, 300);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(177, 57);
            this.DeleteBtn.TabIndex = 10;
            this.DeleteBtn.Text = "Delete Update";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Orange;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateBtn.Location = new System.Drawing.Point(101, 237);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(177, 57);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update Product";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddProbtn
            // 
            this.AddProbtn.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddProbtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddProbtn.Location = new System.Drawing.Point(101, 174);
            this.AddProbtn.Name = "AddProbtn";
            this.AddProbtn.Size = new System.Drawing.Size(177, 57);
            this.AddProbtn.TabIndex = 9;
            this.AddProbtn.Text = "Add Product";
            this.AddProbtn.UseVisualStyleBackColor = false;
            this.AddProbtn.Click += new System.EventHandler(this.AddProbtn_Click);
            // 
            // PriceTb
            // 
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(168, 128);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(149, 28);
            this.PriceTb.TabIndex = 4;
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(103, 128);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(58, 22);
            this.PriceLbl.TabIndex = 1;
            this.PriceLbl.Text = "Price:";
            // 
            // SubMenuDataGrid
            // 
            this.SubMenuDataGrid.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SubMenuDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.SubMenuDataGrid.Name = "SubMenuDataGrid";
            this.SubMenuDataGrid.Size = new System.Drawing.Size(152, 28);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.deleteToolStripMenuItem.Text = "Delete Cell";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1072, 590);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.SubMenuDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PIdlbl;
        private System.Windows.Forms.Label ItemDeslbl;
        private System.Windows.Forms.Label ProNamelbl;
        private System.Windows.Forms.RichTextBox ItemDestb;
        private System.Windows.Forms.TextBox ProNametb;
        private System.Windows.Forms.TextBox PIDtb;
        private System.Windows.Forms.ComboBox CategoryCombo;
        private System.Windows.Forms.Label CatLbl;
        private System.Windows.Forms.Button AddCatbtn;
        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddProbtn;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.ContextMenuStrip SubMenuDataGrid;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}

