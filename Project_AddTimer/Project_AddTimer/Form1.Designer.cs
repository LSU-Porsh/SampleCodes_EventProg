namespace Project_AddTimer
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
            this.TimerDisplaylbl = new System.Windows.Forms.Label();
            this.AddTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimerDisplaylbl
            // 
            this.TimerDisplaylbl.AutoSize = true;
            this.TimerDisplaylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerDisplaylbl.Location = new System.Drawing.Point(182, 137);
            this.TimerDisplaylbl.Name = "TimerDisplaylbl";
            this.TimerDisplaylbl.Size = new System.Drawing.Size(81, 29);
            this.TimerDisplaylbl.TabIndex = 0;
            this.TimerDisplaylbl.Text = "label1";
            this.TimerDisplaylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddTimer
            // 
            this.AddTimer.Tick += new System.EventHandler(this.AddTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 263);
            this.Controls.Add(this.TimerDisplaylbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimerDisplaylbl;
        private System.Windows.Forms.Timer AddTimer;
    }
}

