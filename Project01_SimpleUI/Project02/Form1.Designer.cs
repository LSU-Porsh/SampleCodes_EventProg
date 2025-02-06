namespace Project02
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 66);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(113, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(113, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(113, 103);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(37, 21);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 222);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(390, 19);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(193, 171);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Gender";
            groupBox2.Enter += groupBox2_Enter_1;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(20, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(159, 27);
            textBox4.TabIndex = 10;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(20, 67);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(78, 24);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Female";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += groupBox2_Enter;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(20, 97);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 24);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Others";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += groupBox2_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 37);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(63, 24);
            radioButton1.TabIndex = 7;
            radioButton1.TabStop = true;
            radioButton1.Text = "Male";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += groupBox2_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 110);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Contact No.";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(6, 28);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(116, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Desktop Dev";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += groupBox3_Enter;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(6, 58);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(159, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Full-Stack Web Dev";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += groupBox3_Enter;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(6, 88);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(162, 24);
            checkBox3.TabIndex = 9;
            checkBox3.Text = "Front-End Web Deb";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(6, 118);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(157, 24);
            checkBox4.TabIndex = 10;
            checkBox4.Text = "Back-End Web Dev";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckStateChanged += button1_Click;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(6, 148);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(140, 24);
            checkBox5.TabIndex = 11;
            checkBox5.Text = "Mobile App Dev";
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += groupBox3_Enter;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(180, 28);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(159, 24);
            checkBox6.TabIndex = 12;
            checkBox6.Text = "Cross-Platform Dev";
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += groupBox3_Enter;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(180, 58);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(108, 24);
            checkBox7.TabIndex = 13;
            checkBox7.Text = "Networking";
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += groupBox3_Enter;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox6);
            groupBox3.Controls.Add(checkBox7);
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(checkBox2);
            groupBox3.Controls.Add(checkBox5);
            groupBox3.Controls.Add(checkBox3);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Location = new Point(37, 249);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(343, 180);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Interests";
            // 
            // button1
            // 
            button1.Location = new Point(427, 346);
            button1.Name = "button1";
            button1.Size = new Size(142, 29);
            button1.TabIndex = 15;
            button1.Text = "Submit Form";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 592);
            Controls.Add(button1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private RadioButton radioButton3;
        private TextBox textBox4;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private GroupBox groupBox3;
        private Button button1;
    }
}