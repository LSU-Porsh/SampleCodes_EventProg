namespace FirstProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbFirstName = new Label();
            tbFirstName = new TextBox();
            lbLastName = new Label();
            tbLastName = new TextBox();
            lbDisplay = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnClear = new Button();
            btnOk = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Location = new Point(14, 9);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(84, 25);
            lbFirstName.TabIndex = 0;
            lbFirstName.Text = "First Name";
            lbFirstName.UseCompatibleTextRendering = true;
            // 
            // tbFirstName
            // 
            tbFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbFirstName.HideSelection = false;
            tbFirstName.Location = new Point(14, 37);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(407, 27);
            tbFirstName.TabIndex = 1;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Location = new Point(14, 85);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(82, 25);
            lbLastName.TabIndex = 2;
            lbLastName.Text = "Last Name";
            lbLastName.UseCompatibleTextRendering = true;
            // 
            // tbLastName
            // 
            tbLastName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbLastName.Location = new Point(14, 113);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(407, 27);
            tbLastName.TabIndex = 3;
            // 
            // lbDisplay
            // 
            lbDisplay.AutoSize = true;
            lbDisplay.Location = new Point(14, 281);
            lbDisplay.Name = "lbDisplay";
            lbDisplay.Size = new Size(126, 25);
            lbDisplay.TabIndex = 4;
            lbDisplay.Text = "Display Message";
            lbDisplay.UseCompatibleTextRendering = true;
            lbDisplay.Click += lbDisplay_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.2F));
            tableLayoutPanel1.Controls.Add(btnClear, 1, 0);
            tableLayoutPanel1.Controls.Add(btnOk, 0, 0);
            tableLayoutPanel1.Location = new Point(63, 364);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(291, 49);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(145, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 43);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(3, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(135, 43);
            btnOk.TabIndex = 6;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 450);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbDisplay);
            Controls.Add(tbLastName);
            Controls.Add(lbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(lbFirstName);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFirstName;
        private TextBox tbFirstName;
        private Label lbLastName;
        private TextBox tbLastName;
        private Label lbDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnClear;
        private Button btnOk;
    }
}