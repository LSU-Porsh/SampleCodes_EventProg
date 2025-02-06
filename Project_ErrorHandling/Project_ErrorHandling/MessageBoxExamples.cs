using System;
using System.Windows.Forms;

namespace Project_ErrorHandling
{
    public partial class MessageBoxExamples : Form
    {
        public MessageBoxExamples()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.YesNo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.YesNoCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.OK);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.OKCancel);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.AbortRetryIgnore);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.RetryCancel);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
        }



        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button10_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Message", "Title", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void button11_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Message", "Title", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Information);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBoxCondition con = new MessageBoxCondition();
            con.ShowDialog();
        }
    }
}
