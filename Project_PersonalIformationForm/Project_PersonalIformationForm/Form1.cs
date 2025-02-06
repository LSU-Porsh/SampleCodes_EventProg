using System.Data;

namespace Project_PersonalIformationForm
{
    public partial class Form1 : Form
    {
        DataTable person = new DataTable();
        public string name;
        public int age;
        public int id;
        public string bdate;
        public string email;
        public bool isValid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            person.Columns.Add("PersonID", typeof(int));
            person.Columns.Add("Name", typeof(string));
            person.Columns.Add("Age", typeof(string));
            person.Columns.Add("Birthdate", typeof(string));
            person.Columns.Add("Email", typeof(String));
            PersonDataGrid.DataSource = person;
        }

        private void FullNameTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            name = FullNameTB.Text;
            errorProvider1.SetError(FullNameTB, "");
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Name Field is Empty", "Empty Required Field", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                errorProvider1.SetError(FullNameTB, "Error");
            }
            errorProvider1.SetError(FullNameTB, "");
            isValid = true;


        }

        private void AgeTB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                age = int.Parse(AgeTB.Text);

            }

            catch (FormatException)

            {
                MessageBox.Show("Wrong Input:Not an Integer", "Error Format", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            int myAge = DateTime.Today.Year - BirthdatePicker.Value.Year;
            label6.Text = myAge.ToString();

        }
    }
}