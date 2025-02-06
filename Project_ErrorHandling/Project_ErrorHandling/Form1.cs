using System;
using System.Windows.Forms;

namespace Project_ErrorHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textBox1.Text);
                int num2 = int.Parse(textBox2.Text);

                MessageBox.Show("Successful");
                DialogResult result = MessageBox.Show("Click YES for FORM2 \n Click NO for FORM3", "Proceed",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    //2nd form example
                    MessageBoxExamples example = new MessageBoxExamples();
                    example.Show();
                }
                else
                {
                    MessageBoxCondition sample = new MessageBoxCondition();
                    sample.Show();
                }


            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception input valid number");
            }


        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                int y = Int32.Parse(textBox1.Text);
                errorProvider1.SetError(textBox1, "");
            }
            catch (Exception)
            {
                errorProvider1.SetError(textBox1, "Not a integer value.");
            }
        }

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            try
            {
                int x = Int32.Parse(textBox2.Text);
                errorProvider1.SetError(textBox2, "");

            }
            catch (Exception)

            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Not a  number");
            }
        }
    }
}
