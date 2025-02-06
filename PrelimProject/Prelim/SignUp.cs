using System;
using System.Windows.Forms;

namespace Prelim
{
    public partial class SignUp : Form
    {

        public static string fname;
        public static string lname;
        public static string bdate;
        public static string address;
        public static string pinNum;
        public static string sex;
        public SignUp()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            fname = textBox1.Text;
            lname = textBox2.Text;
            bdate = textBox3.Text;
            address = textBox4.Text;
            pinNum = textBox5.Text;

            if (radioButton1.Checked == true)
            {
                sex = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                sex = radioButton2.Text;
            }

            //DashBoard dash = new DashBoard(fname, lname, bdate, address, sex);

            if (pinNum == textBox6.Text)
            {
                DashBoard dboard = new DashBoard(pinNum, false, fname, lname, address, bdate, sex);
                dboard.Show();
                //  Info info = new Info(fname, lname, address, bdate, sex);

            }
            else
            {
                MessageBox.Show("PIN not match");
            }




        }



        private void button2_Click(object sender, EventArgs e)
        {

            //if (pinNum == textBox6.Text)
            //{
            //    MessageBox.Show("PIN is Match");
            //}
            //else
            //{
            //    MessageBox.Show("PIN not match");
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
