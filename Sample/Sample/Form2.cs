namespace Sample
{
    public partial class Form2 : Form
    {

        public string name;
        public int id;
        public Form2(int id, string name)
        {
            InitializeComponent();
            this.name = name;
            this.id = id;


        }

        private void Form2_Load(object sender, EventArgs e)
        {

            TableDataSource viewdata = new TableDataSource();
            dataGridView1.DataSource = viewdata.CreateData(this.name, this.id); ;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 addnewdata = new Form1();
            addnewdata.ShowDialog();
        }
    }
}
