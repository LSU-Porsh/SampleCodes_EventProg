using System.Windows.Forms;

namespace Prooject_CountDown
{
    public partial class CountDown : Form
    {
        public CountDown()
        {
            InitializeComponent();
        }
        int seconds = 0;
        private void StartBtn_Click(object sender, System.EventArgs e)
        {
            seconds = 10;//it start at 10 then going down
            CountDownTimer.Start();
        }

        private void CountDownTimer_Tick(object sender, System.EventArgs e)
        {
            TimerLabel.Text = seconds--.ToString();
            if (seconds < 0)
            {
                CountDownTimer.Stop();
                MessageBox.Show("COUNTDOWN IS STOP");
            }
        }
    }
}
