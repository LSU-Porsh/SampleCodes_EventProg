namespace AppSample
{
    partial class frmMessage
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
            this.lblDisplayMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisplayMessage
            // 
            this.lblDisplayMessage.AutoSize = true;
            this.lblDisplayMessage.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMessage.Location = new System.Drawing.Point(112, 80);
            this.lblDisplayMessage.Name = "lblDisplayMessage";
            this.lblDisplayMessage.Size = new System.Drawing.Size(276, 32);
            this.lblDisplayMessage.TabIndex = 0;
            this.lblDisplayMessage.Text = "Display Message Here";
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayMessage);
            this.Name = "frmMessage";
            this.Text = "frmMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayMessage;
    }
}