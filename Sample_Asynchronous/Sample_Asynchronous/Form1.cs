using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample_Asynchronous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        async Task SummonDog()
        {
            label1.Text = "1. Summon Dog Locally....";


        }
    }
}
