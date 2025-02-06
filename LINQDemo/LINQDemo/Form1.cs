using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resultOne;
        string resultTwo;
        string resultThree;
        string resultFour;
        string message;


        private string name;
        private int age;

        DataTable myDataTable = new DataTable();
        DataTable myDataTable2 = new DataTable();
        DataTable productTable = new DataTable();


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
            myDataTable.Rows.Add(4, "Charlotte", 25);
            myDataTable.Rows.Add(5, "Charlotte", 28);

            OrigData.DataSource = myDataTable;


            //1st Sample without using Data Table
            productTable.Columns.Add("ID", typeof(int));
            productTable.Columns.Add("ProductName", typeof(string));


            // Add some sample data rows
            productTable.Rows.Add(101, "Kape");
            productTable.Rows.Add(102, "Food");

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ArrayBtn_Click(object sender, EventArgs e)
        {
            int[] scores = { 90, 85, 30, 55, 80 };

            var highscore = (from score in scores
                             orderby score ascending
                             select score).Distinct();
            var distinctnumber = scores.Distinct();

            foreach (int score in highscore)
            {
                string ScoreElement = score.ToString();
                resultOne += ScoreElement + ",";
            }


            MessageBox.Show(resultOne);
        }

        private void DataTableTb_Click(object sender, EventArgs e)
        {

            //Using DataTable as a dataset
            // Finding the  customers with the age 28


            //var ageQuery = from row in myDataTable.AsEnumerable()
            //               where row.Field<int>("Age") == 28
            //               select row;

            //foreach (var resultRow in ageQuery)
            //{
            //    int id = resultRow.Field<int>("ID");
            //    string name = resultRow.Field<string>("Name");
            //    int age = resultRow.Field<int>("Age");
            //    resultTwo += id + "," + name + "," + age + "\n";
            //}


            // Projecting over a sequence of objects

            //var NameAge = from row in myDataTable.AsEnumerable()
            //              where row.Field<int>("ID") == 2
            //              select new
            //              {
            //                  name = row.Field<string>("Name"),
            //                  age = row.Field<int>("Age")
            //              };


            //foreach (var record in NameAge)
            //{
            //    resultTwo += $"Name: {record.name} \n Age: {record.age}";
            //}


            //MessageBox.Show("Person with an ID no . 2 \n" + resultTwo);



            ////Distinct Query with filtering
            var DistinctNames = (from row in myDataTable.AsEnumerable()
                                 orderby row.Field<string>("Name") descending
                                 select new
                                 {
                                     name = row.Field<string>("Name")
                                 }).Distinct();





            foreach (var person in DistinctNames)
            {
                resultTwo += person.name.ToString() + ",";
            }
            MessageBox.Show("Here are the Uniques Names in this Data Table \n" + resultTwo + "\n");

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            //Filtering using user input
            //var SearchAge = from row in myDataTable.AsEnumerable()
            //                where row.Field<int>("Age") == int.Parse(SearchTb.Text)
            //                select row;

            //foreach (var resultRow in SearchAge)
            //{
            //    int id = resultRow.Field<int>("ID");
            //    string name = resultRow.Field<string>("Name");
            //    int age = resultRow.Field<int>("Age");
            //    resultThree = id + name + age;
            //}

            //MessageBox.Show(resultThree);

        }




        private void LinqToDaTabBtn_Click(object sender, EventArgs e)
        {

        }

        private void Allbtn_Click(object sender, EventArgs e)
        {

        }

        private void AnyBtn_Click(object sender, EventArgs e)
        {

        }

        private void ContainsBtn_Click(object sender, EventArgs e)
        {

            int[] numbers = { 5, 7, 2, 1, 0 };
            bool hasNumber = (from num in numbers
                              select num).Contains(3); // true if 3 exists in the array

            MessageBox.Show($"Does this array [ 5, 7, 2, 1, 0 ] contains a 3? {hasNumber}");




            //Cannot User Contains() when dealing with Datatable
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            int CountCharlotte = (from person in myDataTable.AsEnumerable()
                                  where person.Field<string>("Name") == "Charlotte"
                                  select person).Count();


            MessageBox.Show($"There are {CountCharlotte} in the Data Table");




            int[] grades = { 80, 75, 75, 91, 92, 76, 75, 80, 75, 86 };

            int CountPassingGrades = (from grade in grades
                                      where grade == 75
                                      select grade).Count();

            MessageBox.Show($"Count the Grades that is 75: {CountPassingGrades}");










        }

        private void AverageBtn_Click(object sender, EventArgs e)
        {

        }

        private void ConversionBtn_Click(object sender, EventArgs e)
        {   //Number 1

            //int[] numbers = { 1, 2, 3, 4, 5, 7 };

            //var squares = from n in numbers
            //              select n * n;




            //foreach (var sq in squares)
            //{
            //    message += $" {sq.ToString()}\n";
            //}
            //MessageBox.Show(message);




            //Number 2
            //int[] numbers = { 5, 7, 2, 1, 0 };

            //bool hasNumber = numbers.Contains(3);



            //MessageBox.Show($"Does this array [ 5, 7, 2, 1, 0 ] contains a 3? {hasNumber}");



            //// Number 3
            int[] grades = { 80, 75, 75, 91, 92, 76, 75, 80, 75, 86 };

            int passing = grades
                .Where(g => g == 75).Count();


            MessageBox.Show($"Count the Grades that is 75: {passing}");


            ////Number 4 Query

            //int[] scores = { 2, 5, 7, 3, 8, 9 };




            //foreach (var score in filteredScores)
            //{
            //    message += score;
            //}

            ////Number5 

            //int[] numbers = { 5, 2, 8, 1, 9, 3 };




            //foreach (var score in sortedNumberQuery)
            //{
            //    message += score;
            //}

            //MessageBox.Show(message);


        }
    }
}
