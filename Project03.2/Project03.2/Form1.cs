namespace Project03._2
{
    public partial class Form1 : Form
    {
        //User admin = new User();
        public Form1()
        {
            InitializeComponent();

            //admin.UserName = "Jane";
            //admin.password = "password";
            //admin.UserLevel = "admin";

        }



        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New Tab");
        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Open");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(button2, 50, 0);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "password")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Incorrect username/password");
            }



        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add New Tab");
        }

        private void newWindowToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }


    //public class User
    //{
    //    public string UserName { get; set; }
    //    public string password { get; set; }
    //    public string UserLevel { get; set; }



    //}
}