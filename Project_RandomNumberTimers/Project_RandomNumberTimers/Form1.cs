using System;
using System.Windows.Forms;

namespace Project_RandomNumberTimers
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private bool isGenerating = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            isGenerating = !isGenerating;
            if (isGenerating)
            {
                timer1.Start();
                button1.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                button1.Text = "Start";
                if (label1.Text == "7" || label2.Text == "7" || label3.Text == "7")
                {
                    MessageBox.Show("CONGRATULATIONS. YOU WIN");
                }
            }



        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            int num1 = rnd.Next(1, 10);

            label1.Text = num1.ToString();
            int num2 = rnd.Next(1, 10);
            label2.Text = num2.ToString();
            int num3 = rnd.Next(1, 10);
            label3.Text = num3.ToString();

        }


    }
}
