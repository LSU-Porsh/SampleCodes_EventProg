using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Sample_LINQ
{
    public partial class Form1 : Form
    {
        string paragraph;
        string scoretext;
        DataTable myDataTable = new DataTable();
        string resultText;

        private string name;
        private int age;
        private string NewParagraph;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //1st Sample without using Data Table
            myDataTable.Columns.Add("ID", typeof(int));
            myDataTable.Columns.Add("Name", typeof(string));
            myDataTable.Columns.Add("Age", typeof(int));

            // Add some sample data rows
            myDataTable.Rows.Add(1, "Alice", 18);
            myDataTable.Rows.Add(2, "Bob", 17);
            myDataTable.Rows.Add(3, "Charlie", 25);
            myDataTable.Rows.Add(4, "Charlotte", 30);

            dataGridView1.DataSource = myDataTable;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Purely LINQ query
            var SearchAge = from row in myDataTable.AsEnumerable()
                            where row.Field<int>("Age") == int.Parse(textBox1.Text)
                            select row;

            foreach (var resultRow in SearchAge)
            {
                int id = resultRow.Field<int>("ID");
                string name = resultRow.Field<string>("Name");
                int age = resultRow.Field<int>("Age");
                resultText = id + name + age;
            }

            MessageBox.Show(resultText);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ageQuery = from row in myDataTable.AsEnumerable()
                           where row.Field<int>("Age") == 28
                           select row;

            foreach (var resultRow in ageQuery)
            {
                int id = resultRow.Field<int>("ID");
                string name = resultRow.Field<string>("Name");
                int age = resultRow.Field<int>("Age");
                paragraph += id + "," + name + "," + age + "\n";
            }
            label1.Text = paragraph;
            MessageBox.Show(paragraph);


            //ANOTHER WAY
            //var ageQuery = from row in myDataTable.AsEnumerable()
            //               where row.Field<int>("Age") == 28 
            //               orderby row.Field<string>("Name") ascending 
            //               select row{
            //                    int id = resultRow.Field<int>("ID");
            //                    string name = resultRow.Field<string>("Name");
            //                    int age = resultRow.Field<int>("Age");
            //            }; 

            //foreach (var resultRow in ageQuery)
            //{

            //    paragraph += id + "," + name + "," + age + "\n";
            //}
            //label1.Text = paragraph;
            //MessageBox.Show(paragraph);


        }


        private void button3_Click(object sender, EventArgs e)
        {
            int[] scores = { 90, 85, 30, 55, 80 };

            var highscore = from score in scores
                            where score > 50
                            select score;

            foreach (int score in highscore)
            {
                string score1 = score.ToString();
                scoretext += score1 + ",";
            }

            label2.Text = scoretext;
            MessageBox.Show(scoretext);
        }

        private void button4_Click(object sender, EventArgs e)
        {


            var LegalAge = from row in myDataTable.AsEnumerable()
                           where row.Field<int>("Age") > 20
                           orderby row.Field<int>("Age") ascending
                           select new
                           {
                               name = row.Field<string>("Name"),
                               age = row.Field<int>("Age")
                           };



        }


    }
}







