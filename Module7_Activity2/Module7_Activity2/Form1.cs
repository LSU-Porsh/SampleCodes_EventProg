using System;
using System.Data;
using System.Windows.Forms;

namespace Module7_Activity2
{
    public partial class Form1 : Form
    {
        DataTable employeeTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1st Sample without using Data Table
            employeeTable.Columns.Add("ID", typeof(int));
            employeeTable.Columns.Add("FirstName", typeof(string));
            employeeTable.Columns.Add("LastName", typeof(string));
            employeeTable.Columns.Add("Sex", typeof(string));
            employeeTable.Columns.Add("IsStudent", typeof(int));
            employeeTable.Columns.Add("University", typeof(string));
            employeeTable.Columns.Add("Age", typeof(int));
            employeeTable.Columns.Add("ContactNo", typeof(string));

            // Add some sample data rows
            employeeTable.Rows.Add(1, "Alice", "Mendoza", "Female", 1, "Cambrige University", 18, "09888888");
            employeeTable.Rows.Add(2, "Bob", "Santos", "Male", 0, "None", 25, "096666666");
            employeeTable.Rows.Add(3, "Charlie", "White", "Female", 1, "Harvard University", 21, "095632658");
            employeeTable.Rows.Add(4, "Charlie", "Puth", "Male", 1, "Cambrige University", 26, "09862354878");
            employeeTable.Rows.Add(5, "Samantha", "Bautista", "Female", 1, "Oxford University", 18, "09862354878");
            employeeTable.Rows.Add(6, "Christian", "Bautista", "Male", 0, "Ateneo de Davao University", 20, "0984568465");
            employeeTable.Rows.Add(7, "Isaac", "Rodriguez", "Male", 0, "Batangas State University", 26, "09886562354");
            employeeTable.Rows.Add(8, "Charlie", " Johnson", "Female", 1, "Oxford University", 23, "095632658");


            EmployeeDataGrid.DataSource = employeeTable;
        }

        private void AllStudentsBtn_Click(object sender, EventArgs e)
        {

        }

        private void All18StudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void UniqueUniBtn_Click(object sender, EventArgs e)
        {

        }

        private void CharlieBtn_Click(object sender, EventArgs e)
        {

        }

        private void TotalStudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
