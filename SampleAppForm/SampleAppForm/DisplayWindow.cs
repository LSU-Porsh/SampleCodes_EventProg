using System.Windows.Forms;

namespace SampleAppForm
{
    public partial class DisplayWindow : Form
    {
        private string fname;
        private string lname;

        public DisplayWindow(string fname, string lname)
        {
            InitializeComponent();

            this.fname = fname;
            this.lname = lname;

            lblDisplayMessage.Text = $"Hello Again My Friend {fname} {lname}";
        }


    }
}
