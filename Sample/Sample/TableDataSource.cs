using System.Data;

namespace Sample
{
    public class TableDataSource
    {

        public string name = "";
        public int id;
        public DataTable mydata = new DataTable();




        public DataTable CreateData(string name, int id)

        {
            mydata.Columns.Add("ID", typeof(int));
            mydata.Columns.Add("name", typeof(string));
            this.name = name;
            this.id = id;
            DataRow newRow = mydata.NewRow();
            newRow[0] = this.id;
            newRow[1] = this.name;

            return mydata;
        }

    }
}
