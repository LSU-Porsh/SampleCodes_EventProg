using System;
using System.Windows.Forms;


namespace Project03._3
{
    public partial class LoginForm : Form
    {
        //List<User> accountList = new List<User>();
        User existingUser1 = new User();
        User existingUser2 = new User();



        public LoginForm()
        {
            InitializeComponent();
            existingUser1.userName = "forcia";
            existingUser1.password = "admin";
            existingUser1.userLevel = "Admin";
            //accountList.Add(existingUser1);


            existingUser2.userName = "jane";
            existingUser2.password = "user";
            existingUser2.userLevel = "user";
            //accountList.Add(existingUser2);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == existingUser1.userName && textBox2.Text == existingUser1.password && existingUser1.userLevel == "Admin")
            {
                this.Visible = false;
                Form2 dashboard = new Form2(true);
                dashboard.ShowDialog();

            }
            else if (textBox1.Text == existingUser2.userName && textBox2.Text == existingUser2.password && existingUser2.userLevel == "user")
            {


                //Login Form set visible to false
                this.Visible = false;
                //create instance of the form 2, set parameter to false  used for updatinng the toolstrip in the form2
                Form2 dashboard = new Form2(false);

                dashboard.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Error creating user:", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }


    public class User
    {
        public string userName { get; set; }
        public string password { get; set; }
        public string userLevel { get; set; }




    }




}
