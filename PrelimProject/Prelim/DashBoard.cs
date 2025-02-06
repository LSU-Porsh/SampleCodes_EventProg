using System.Drawing;
using System.Windows.Forms;

namespace Prelim
{
    public partial class DashBoard : Form
    {
        string result;
        string mypin;

        private string fname;
        private string lname;
        private string address;
        private string bdate;
        private string sex;


        //Initializing Info object
        private Info mycontrol;



        //Constructor
        //get then set the value from SignUp Form to Dashboard
        public DashBoard(string pin, bool settings,
            string fname, string lname, string address, string bdate, string sex)
        {
            InitializeComponent();
            mypin = pin;
            menuStrip1.Items["settingsToolStripMenuItem"].Visible = settings;
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.bdate = bdate;
            this.sex = sex;


        }

        public DashBoard()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            result += '1';
            textBox1.Text = result;
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            result += '2';
            textBox1.Text = result;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            result += '3';
            textBox1.Text = result;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            result += '4';
            textBox1.Text = result;
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            result += '5';
            textBox1.Text = result;
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            result += '6';
            textBox1.Text = result;
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            result += '7';
            textBox1.Text = result;
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            result += '8';
            textBox1.Text = result;
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            result += '9';
            textBox1.Text = result;
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            result += '0';
            textBox1.Text = result;
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            result = null;
            textBox1.Text = null;

        }

        public void button12_Click(object sender, System.EventArgs e)
        {
            if (result == mypin)
            {

                MessageBox.Show("Accessed Successfully");
                //Pass to YourInfo UserControl
                mycontrol = new Info(fname, lname, address, bdate, sex);
                panel2.Controls.Clear();
                panel2.Controls.Add(mycontrol);
                mycontrol.Dock = DockStyle.Fill;
                menuStrip1.Items["settingsToolStripMenuItem"].Visible = true;

            }
            else
            {
                MessageBox.Show("Wrong PIN");
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            panel1.Visible = true;
        }

        private void button15_Click(object sender, System.EventArgs e)
        {
            contextMenuStrip1.Show(button15, 50, 50);
        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            contextMenuStrip2.Show(button14, 50, 50);
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        public void blackToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mycontrol.ChangeColor(Color.Red);

        }


        private void blueToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            mycontrol.ChangeColor(Color.Blue);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arialToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mycontrol.ChangeFontVerdana();
        }

        private void timesNewRomaToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            mycontrol.ChangeFontTimes();
        }
    }
}
