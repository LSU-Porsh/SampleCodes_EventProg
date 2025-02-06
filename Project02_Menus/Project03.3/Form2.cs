using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project03._3
{
    public partial class Form2 : Form
    {

        //Constructor
        public Form2(bool enableMenu)
        {
            InitializeComponent();

            menuStrip1.Items["categoryToolStripMenuItem"].ForeColor = Color.Red;
            menuStrip1.Items["toolStripTextBox1"].Visible = enableMenu;
            menuStrip1.Items["categoryToolStripMenuItem"].Visible = enableMenu;
            menuStrip1.Items["productToolStripMenuItem"].Visible = enableMenu;
            menuStrip1.Items["memberToolStripMenuItem"].Visible = enableMenu;
            menuStrip1.Items["supplierToolStripMenuItem"].Visible = enableMenu;
            menuStrip1.Items["userToolStripMenuItem"].Visible = enableMenu;

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }


        private void updateMenuNormal(bool enableMenu)
        {


        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryPanel.Visible = true;
        }
    }
}
