using System;
using System.Windows.Forms;

namespace Project_AddTimer
{   //set the Date Time as the time simulate in real time
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Windows.Forms.Timer time = null;

        private void AddTimer_Tick(object sender, EventArgs e)
        {
            TimerDisplaylbl.Text = DateTime.Now.ToString();
        }


        private void StartTimer()
        {
            time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(AddTimer_Tick);
            time.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StartTimer();
        }
    }
}
