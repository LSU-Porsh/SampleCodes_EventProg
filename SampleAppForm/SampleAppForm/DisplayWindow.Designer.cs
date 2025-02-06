namespace SampleAppForm
{
    partial class DisplayWindow
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
            this.lblDisplayMessage.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayMessage.Location = new System.Drawing.Point(105, 144);
            this.lblDisplayMessage.Name = "lblDisplayMessage";
            this.lblDisplayMessage.Size = new System.Drawing.Size(357, 31);
            this.lblDisplayMessage.TabIndex = 0;
            this.lblDisplayMessage.Text = "Display in another Form";
            // 
            // DisplayWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDisplayMessage);
            this.Name = "DisplayWindow";
            this.Text = "DisplayWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplayMessage;
    }
}