namespace Sample
{
    public partial class Form1 : Form
    {
        string name = " ";
        int id;
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            id = int.Parse(textBox2.Text);

            Form2 form2 = new Form2(id, name);
            form2.ShowDialog();
        }
    }
}