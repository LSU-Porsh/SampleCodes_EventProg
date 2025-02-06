using System.Windows.Forms;

namespace AppSample
{
    public partial class frmMessage : Form
    {
        private string fname;
        private string lname;
        public frmMessage(string fname, string lname)
        {
            InitializeComponent();

            this.fname = fname;
            this.lname = lname;
            lblDisplayMessage.Text = $"Hello User {fname} {lname}. ";

        }


    }
}
