namespace Midterm_EventMngmt
{
    partial class EventView
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
            this.SearchEventIDTB = new System.Windows.Forms.TextBox();
            this.StartCdownBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.DisplayCountdownlbl = new System.Windows.Forms.Label();
            this.EndCDownbtn = new System.Windows.Forms.Button();
            this.SearchIDbtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Selectbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PreviewEventbtn = new System.Windows.Forms.Button();
            this.EventDetailsView = new System.Windows.Forms.DataGridView();
            this.Event_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search Event ID";
            // 
            // SearchEventIDTB
            // 
            this.SearchEventIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEventIDTB.Location = new System.Drawing.Point(16, 429);
            this.SearchEventIDTB.Name = "SearchEventIDTB";
            this.SearchEventIDTB.Size = new System.Drawing.Size(175, 30);
            this.SearchEventIDTB.TabIndex = 2;
            // 
            // StartCdownBtn
            // 
            this.StartCdownBtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCdownBtn.Location = new System.Drawing.Point(12, 552);
            this.StartCdownBtn.Name = "StartCdownBtn";
            this.StartCdownBtn.Size = new System.Drawing.Size(125, 42);
            this.StartCdownBtn.TabIndex = 3;
            this.StartCdownBtn.Text = "Start";
            this.StartCdownBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 472);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Event CountDown:";
            // 
            // DisplayCountdownlbl
            // 
            this.DisplayCountdownlbl.AutoSize = true;
            this.DisplayCountdownlbl.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayCountdownlbl.Location = new System.Drawing.Point(26, 31);
            this.DisplayCountdownlbl.Name = "DisplayCountdownlbl";
            this.DisplayCountdownlbl.Size = new System.Drawing.Size(212, 23);
            this.DisplayCountdownlbl.TabIndex = 4;
            this.DisplayCountdownlbl.Text = "Timer Countdown Here";
            // 
            // EndCDownbtn
            // 
            this.EndCDownbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndCDownbtn.Location = new System.Drawing.Point(12, 597);
            this.EndCDownbtn.Name = "EndCDownbtn";
            this.EndCDownbtn.Size = new System.Drawing.Size(125, 42);
            this.EndCDownbtn.TabIndex = 3;
            this.EndCDownbtn.Text = "End";
            this.EndCDownbtn.UseVisualStyleBackColor = true;
            // 
            // SearchIDbtn
            // 
            this.SearchIDbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchIDbtn.Location = new System.Drawing.Point(197, 423);
            this.SearchIDbtn.Name = "SearchIDbtn";
            this.SearchIDbtn.Size = new System.Drawing.Size(125, 42);
            this.SearchIDbtn.TabIndex = 3;
            this.SearchIDbtn.Text = "Search";
            this.SearchIDbtn.UseVisualStyleBackColor = true;
            // 
            // Addbtn
            // 
            this.Addbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.Location = new System.Drawing.Point(469, 423);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(125, 42);
            this.Addbtn.TabIndex = 3;
            this.Addbtn.Text = "Add Event";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.DisplayCountdownlbl);
            this.panel1.Location = new System.Drawing.Point(143, 552);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 87);
            this.panel1.TabIndex = 5;
            // 
            // Selectbtn
            // 
            this.Selectbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Selectbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selectbtn.Location = new System.Drawing.Point(338, 423);
            this.Selectbtn.Name = "Selectbtn";
            this.Selectbtn.Size = new System.Drawing.Size(125, 42);
            this.Selectbtn.TabIndex = 3;
            this.Selectbtn.Text = "Select";
            this.Selectbtn.UseVisualStyleBackColor = true;
            this.Selectbtn.Click += new System.EventHandler(this.Selectbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(456, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "Display the Selected Event Title Here";
            // 
            // PreviewEventbtn
            // 
            this.PreviewEventbtn.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviewEventbtn.Location = new System.Drawing.Point(616, 423);
            this.PreviewEventbtn.Name = "PreviewEventbtn";
            this.PreviewEventbtn.Size = new System.Drawing.Size(125, 42);
            this.PreviewEventbtn.TabIndex = 3;
            this.PreviewEventbtn.Text = "Preview";
            this.PreviewEventbtn.UseVisualStyleBackColor = true;
            // 
            // EventDetailsView
            // 
            this.EventDetailsView.AllowUserToAddRows = false;
            this.EventDetailsView.AllowUserToDeleteRows = false;
            this.EventDetailsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDetailsView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Event_Name});
            this.EventDetailsView.GridColor = System.Drawing.SystemColors.Highlight;
            this.EventDetailsView.Location = new System.Drawing.Point(12, 12);
            this.EventDetailsView.Name = "EventDetailsView";
            this.EventDetailsView.ReadOnly = true;
            this.EventDetailsView.RowHeadersWidth = 51;
            this.EventDetailsView.RowTemplate.Height = 24;
            this.EventDetailsView.Size = new System.Drawing.Size(1131, 365);
            this.EventDetailsView.TabIndex = 0;
            // 
            // Event_Name
            // 
            this.Event_Name.HeaderText = "EventName";
            this.Event_Name.MinimumWidth = 6;
            this.Event_Name.Name = "Event_Name";
            this.Event_Name.ReadOnly = true;
            this.Event_Name.Width = 125;
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.EndCDownbtn);
            this.Controls.Add(this.PreviewEventbtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.Selectbtn);
            this.Controls.Add(this.SearchIDbtn);
            this.Controls.Add(this.StartCdownBtn);
            this.Controls.Add(this.SearchEventIDTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventDetailsView);
            this.Name = "EventView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event DashBoard";
            this.Load += new System.EventHandler(this.EventView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDetailsView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchEventIDTB;
        private System.Windows.Forms.Button StartCdownBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DisplayCountdownlbl;
        private System.Windows.Forms.Button EndCDownbtn;
        private System.Windows.Forms.Button SearchIDbtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Selectbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PreviewEventbtn;
        private System.Windows.Forms.DataGridView EventDetailsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event_Name;
    }
}