using System.Windows.Forms;

namespace SampleAppForm
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, System.EventArgs e)
        {
            string fname = tbFirstName.Text;
            string lname = tbLastName.Text;

            lblMessage.Text = $"Hello! Welcome User \n{fname} {lname}";

            DisplayWindow diswin = new DisplayWindow(fname, lname);
            diswin.ShowDialog();
        }
    }
}
