namespace Project03._4
{
    public partial class RiddleUserControl : UserControl
    {
        public RiddleUserControl()
        {
            InitializeComponent();
        }

        private void Function1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Checked && checkBox2.CheckState == CheckState.Checked && checkBox3.CheckState == CheckState.Checked)
            {
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Try Again");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "echo" || textBox2.Text == "Echo" || textBox2.Text == "ECHO")
            {
                DialogResult result = MessageBox.Show("Do you want to continue?", "Confirmation",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);




                //MessageBox.Show("good");
            }
            else
            {
                MessageBox.Show("bad");
            }
        }
    }
}
