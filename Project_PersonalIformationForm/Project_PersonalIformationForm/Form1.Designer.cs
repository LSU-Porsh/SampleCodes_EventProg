namespace Project_PersonalIformationForm
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
            components = new System.ComponentModel.Container();
            FullNameTB = new TextBox();
            label1 = new Label();
            AgeTB = new TextBox();
            EmailTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            PersonDataGrid = new DataGridView();
            BirthdatePicker = new DateTimePicker();
            label4 = new Label();
            errorProvider1 = new ErrorProvider(components);
            RegisterBtn = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)PersonDataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // FullNameTB
            // 
            FullNameTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FullNameTB.Location = new Point(149, 55);
            FullNameTB.Name = "FullNameTB";
            FullNameTB.Size = new Size(272, 34);
            FullNameTB.TabIndex = 0;
            FullNameTB.Validating += FullNameTB_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 61);
            label1.Name = "label1";
            label1.Size = new Size(106, 28);
            label1.TabIndex = 1;
            label1.Text = "First Name";
            // 
            // AgeTB
            // 
            AgeTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTB.Location = new Point(149, 152);
            AgeTB.Name = "AgeTB";
            AgeTB.Size = new Size(272, 34);
            AgeTB.TabIndex = 0;
            AgeTB.Validating += AgeTB_Validating;
            // 
            // EmailTB
            // 
            EmailTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EmailTB.Location = new Point(149, 268);
            EmailTB.Name = "EmailTB";
            EmailTB.Size = new Size(272, 34);
            EmailTB.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(90, 152);
            label2.Name = "label2";
            label2.Size = new Size(47, 28);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(38, 211);
            label3.Name = "label3";
            label3.Size = new Size(99, 28);
            label3.TabIndex = 1;
            label3.Text = "Birth Date";
            // 
            // PersonDataGrid
            // 
            PersonDataGrid.AllowUserToAddRows = false;
            PersonDataGrid.AllowUserToDeleteRows = false;
            PersonDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PersonDataGrid.Location = new Point(12, 355);
            PersonDataGrid.Name = "PersonDataGrid";
            PersonDataGrid.ReadOnly = true;
            PersonDataGrid.RowHeadersWidth = 51;
            PersonDataGrid.RowTemplate.Height = 29;
            PersonDataGrid.Size = new Size(490, 216);
            PersonDataGrid.TabIndex = 2;
            // 
            // BirthdatePicker
            // 
            BirthdatePicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BirthdatePicker.Format = DateTimePickerFormat.Short;
            BirthdatePicker.Location = new Point(149, 206);
            BirthdatePicker.Name = "BirthdatePicker";
            BirthdatePicker.Size = new Size(272, 34);
            BirthdatePicker.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(78, 268);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 1;
            label4.Text = "Email";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // RegisterBtn
            // 
            RegisterBtn.Location = new Point(158, 591);
            RegisterBtn.Name = "RegisterBtn";
            RegisterBtn.Size = new Size(166, 29);
            RegisterBtn.TabIndex = 4;
            RegisterBtn.Text = "Register";
            RegisterBtn.UseVisualStyleBackColor = true;
            RegisterBtn.Click += RegisterBtn_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 107);
            label5.Name = "label5";
            label5.Size = new Size(103, 28);
            label5.TabIndex = 1;
            label5.Text = "Last Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(149, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 34);
            textBox1.TabIndex = 0;
            textBox1.Validating += FullNameTB_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(172, 319);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 5;
            label6.Text = "Age here: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 721);
            Controls.Add(label6);
            Controls.Add(RegisterBtn);
            Controls.Add(BirthdatePicker);
            Controls.Add(PersonDataGrid);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(EmailTB);
            Controls.Add(AgeTB);
            Controls.Add(textBox1);
            Controls.Add(FullNameTB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)PersonDataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FullNameTB;
        private Label label1;
        private TextBox AgeTB;
        private TextBox EmailTB;
        private Label label2;
        private Label label3;
        private DataGridView PersonDataGrid;
        private DateTimePicker BirthdatePicker;
        private Label label4;
        private ErrorProvider errorProvider1;
        private Button RegisterBtn;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
    }
}