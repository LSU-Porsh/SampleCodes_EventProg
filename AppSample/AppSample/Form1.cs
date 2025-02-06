using System;
using System.Windows.Forms;

namespace AppSample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string FirstName = tbFName.Text;
            string LastName = tbLName.Text;

            lblMessage.Text = "Hello User " + FirstName + " " + LastName;

            frmMessage mesWind = new frmMessage(FirstName, LastName);
            mesWind.ShowDialog();
        }
    }
}
