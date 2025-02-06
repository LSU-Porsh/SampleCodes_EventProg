namespace FirstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            lbDisplay.Text = "Try Again";
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String firstName;
            String lastName;

            firstName = tbFirstName.Text; // to read the user input using Textbox
            lastName = tbLastName.Text;
            lbDisplay.Text = "Hello to the Worl " + firstName + " " + lastName; //display using Label

        }


    }
}