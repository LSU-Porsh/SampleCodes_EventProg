namespace Project01
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
            button1 = new Button();
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            label1 = new Label();
            checkBox2 = new CheckBox();
            button2 = new Button();
            checkBox3 = new CheckBox();
            button3 = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button4 = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.PaleGoldenrod;
            button1.Location = new Point(52, 44);
            button1.Name = "button1";
            button1.Size = new Size(108, 39);
            button1.TabIndex = 0;
            button1.Text = "Display";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(52, 89);
            textBox1.MaxLength = 100;
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '5';
            textBox1.PlaceholderText = "Enter Here";
            textBox1.Size = new Size(320, 27);
            textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "C++";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckStateChanged += groupBox2_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(422, 291);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 56);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(49, 24);
            checkBox2.TabIndex = 5;
            checkBox2.Text = "C#";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckStateChanged += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(378, 89);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 6;
            button2.Text = "Enter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 93);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(59, 24);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Java";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckStateChanged += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(132, 53);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 7;
            button3.Text = "Show";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += button4_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 86);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += button4_Click;
            // 
            // button4
            // 
            button4.Location = new Point(156, 54);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 8;
            button4.Text = "Show";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(52, 220);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Location = new Point(422, 153);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 125);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Programming Languages";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // Form1
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "p";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private Label label1;
        private CheckBox checkBox2;
        private Button button2;
        private CheckBox checkBox3;
        private Button button3;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Button button4;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}