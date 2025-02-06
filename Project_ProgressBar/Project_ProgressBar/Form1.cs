using System;
using System.Windows.Forms;

namespace Project_ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            ProgressBar.Minimum = 0;
            ProgressBar.Maximum = 100;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            ProgressBar.Value = count;

            if (count == 100)
            {
                timer1.Enabled = false;
                MessageBox.Show("Completed");
            }
        }
    }
}
