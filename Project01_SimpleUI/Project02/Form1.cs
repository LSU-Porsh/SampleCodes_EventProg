namespace Project02
{
    public partial class Form1 : Form
    {
        private List<string> list = new List<string>();
        string gender;
        public Form1()
        {
            InitializeComponent();
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox4.Enabled = false;
                gender = radioButton1.Text;


            }
            else if (radioButton2.Checked == true)
            {
                textBox4.Enabled = false;
                gender = radioButton1.Text;

            }
            else if (radioButton3.Checked == true)
            {

                textBox4.Enabled = true;
                gender = textBox4.Text;


            }
        }

        private void groupBox2_Enter_1(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Item");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showContextMeniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //contextMenuStrip1.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {


            }

            if (checkBox2.CheckState == CheckState.Checked)
            {
                list.Add(checkBox2.Text);
                //checkBox2.CheckState = CheckState.Unchecked;

            }

            if (checkBox3.CheckState == CheckState.Checked)
            {
                list.Add(checkBox3.Text);
                //checkBox3.CheckState = CheckState.Unchecked;

            }
            if (checkBox4.CheckState == CheckState.Checked)
            {
                list.Add(checkBox4.Text);

            }
            if (checkBox5.CheckState == CheckState.Checked)
            {
                list.Add(checkBox6.Text);

            }
            if (checkBox6.CheckState == CheckState.Checked)
            {
                list.Add(checkBox7.Text);

            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string lname = textBox2.Text;
            string cnumber = textBox3.Text;
            MessageBox.Show("Name: " + name + lname + "\n" + "ContactNumber: " + "\n" + cnumber + "\n" + "Gender: " + gender + "\n" + "Interests: " + "\n" + string.Join("\n", list));

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}