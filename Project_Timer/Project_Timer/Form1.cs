using System;
using System.Timers;
using System.Windows.Forms;

namespace Project_Timer
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        int h, m, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000; //1s
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s += 1;
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                TimerTB.Text = ;

            }));
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
    }
}
