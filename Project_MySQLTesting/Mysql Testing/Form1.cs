using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Mysql_Testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //string connetionString = null;
            //MySqlConnection cnn;
            //connetionString = "server=localhost;port=3308;database=employeesystem;uid=porshDB;pwd=12051998";
            //cnn = new MySqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    MessageBox.Show("Connection Open ! ");

            //    cnn.Close();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! ");
            //}



            MySql.Data.MySqlClient.MySqlConnection conn;
            string myConnectionString;

            myConnectionString = "server=localhost;port=3308;" +
                "database=employeesystem;uid=porshDB;pwd=12051998";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection(myConnectionString);
                conn.Open();
                MessageBox.Show("Connection Open ! ");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Can not open connection ! ");

            }

        }



        private void AddBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3308;database=employeesystem;uid=porshDB;pwd=12051998";
            string query = "INSERT INTO tblemployeelist(EMPID,FIRSTNAME,MI,LASTNAME,GENDER,POSITION)VALUES('" + this.EMPID.Text + "','" + this.FIRSTNAME.Text + "','" + this.MI.Text + "','" + this.LASTNAME.Text + "','" + this.GENDER.Text + "','" + this.POSITION.Text + "')";

            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            conn.Close();


            MessageBox.Show("Successfully saved");
            conn.Close();


        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3308;database=employeesystem;uid=porshDB;pwd=12051998";
            string query = "UPDATE tblemployeelist SET FIRSTNAME='" + this.FIRSTNAME.Text + "',MI='" + this.MI.Text + "',LASTNAME='" + this.LASTNAME.Text + "',GENDER='" + this.GENDER.Text + "',POSITION='" + this.POSITION.Text + "' WHERE EMPID='" + this.EMPID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Record has been updated successfully");
            conn.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3308;database=employeesystem;uid=porshDB;pwd=12051998";
            string query = "DELETE FROM tblemployeelist WHERE EMPID='" + this.EMPID.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("Data has been succesfully deleted!!");
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;port=3308;database=employeesystem;uid=porshDB;pwd=12051998";
            string query = "SELECT * FROM tblemployeelist";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
