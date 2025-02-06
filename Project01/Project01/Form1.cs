namespace Project01
{
    public partial class Form1 : Form
    {
        List<string> proglang = new List<string>();
        private string result;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(button1.Text + " button is clicked");

            label1.Text = "Hello World";


        }



        private void button2_Click(object sender, EventArgs e)
        {
            //label1.Text = textBox1.Text;

            string randomString = textBox1.Text;
            label1.Text = randomString;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                MessageBox.Show("You are " + radioButton1.Text);

            }
            else if (radioButton2.Checked == true)
            {
                MessageBox.Show("You are " + radioButton2.Text);

            }
            else if (radioButton3.Checked == true)
            {
                MessageBox.Show("You are " + radioButton3.Text);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                //MessageBox.Show(checkBox1.Text);
                proglang.Add(checkBox1.Text);


            }
            else if (checkBox2.Checked == true)
            {
                //MessageBox.Show(checkBox2.Text);
                proglang.Add(checkBox2.Text);

            }
            else if (checkBox3.Checked == true)
            {
                //MessageBox.Show(checkBox3.Text);
                proglang.Add(checkBox3.Text);

            }


        }


        private void button3_Click(object sender, EventArgs e)

        {
            result = string.Join(", ", proglang.ToArray());
            label1.Text = result;


        }
    }
}

