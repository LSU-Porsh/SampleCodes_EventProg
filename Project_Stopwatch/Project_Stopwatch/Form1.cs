using System;
using System.Timers;
using System.Windows.Forms;

namespace Project_Stopwatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Timers.Timer timer1;
        int h, m, s;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1 = new System.Timers.Timer();
            timer1.Interval = 1;
            timer1.Elapsed += OnTimeEvent
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            invoke(new Action(()))
        }
    }
}
