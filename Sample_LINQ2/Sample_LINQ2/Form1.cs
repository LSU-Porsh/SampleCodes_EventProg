using System;
using System.Data;
using System.Windows.Forms;

namespace LINQ_Activity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable customerTable = new DataTable();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Headers of the Sample Data
            customerTable.Columns.Add("ID", typeof(int));
            customerTable.Columns.Add("FirstName", typeof(string));
            customerTable.Columns.Add("LastName", typeof(string));
            customerTable.Columns.Add("Sex", typeof(string));
            customerTable.Columns.Add("IsStudent", typeof(int));
            customerTable.Columns.Add("University", typeof(string));
            customerTable.Columns.Add("Age", typeof(int));
            customerTable.Columns.Add("ContactNo", typeof(string));

            // Sample Data
            customerTable.Rows.Add(1, "Alice", "Mendoza", "Female", 1, "Cambrige University", 18, "09888888");
            customerTable.Rows.Add(2, "Bob", "Santos", "Male", 0, "None", 25, "096666666");
            customerTable.Rows.Add(3, "Charlie", "White", "Female", 1, "Harvard University", 21, "095632658");
            customerTable.Rows.Add(4, "Charlie", "Puth", "Male", 1, "Cambrige University", 26, "09862354878");
            customerTable.Rows.Add(5, "Samantha", "Bautista", "Female", 1, "Oxford University", 18, "09862354878");
            customerTable.Rows.Add(6, "Raina", "Beltran", "Female", 1, "Batangas State University", 17, "0911-1125-652");
            customerTable.Rows.Add(7, "Kaley", "Bradford", "Male", 0, "None", 16, "0988-563-4523");
            customerTable.Rows.Add(8, "Alvin", "Villarreal", "Male", 1, "Batangas State University", 21, "0987-5565-652");
            customerTable.Rows.Add(9, "Wilson", "Carrillo", "Male", 1, "Ateneo de Davao University", 19, "0956-8569-883");

            CustomerDataGrid.DataSource = customerTable;
        }







    }
}
