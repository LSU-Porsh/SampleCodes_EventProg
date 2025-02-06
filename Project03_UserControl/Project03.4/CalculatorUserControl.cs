namespace Project03._4
{
    public partial class CalculatorUserControl : UserControl
    {
        public CalculatorUserControl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int one = Convert.ToInt32(textBox1.Text);
            int two = Convert.ToInt32(textBox2.Text);

            int result = 0;

            if (radioButton1.Checked == true)
            {
                result = one + two;

            }
            else if (radioButton2.Checked == true)
            {
                result = one - two;
            }
            else if (radioButton3.Checked == true)
            {
                result = one * two;

            }
            else if (radioButton4.Checked == true)
            {
                result = one / two;


            }


            MessageBox.Show("The total is " + result);
        }
    }
}
