using System.Drawing;
using System.Windows.Forms;

namespace Prelim
{
    public partial class Info : UserControl
    {
        private string fname;
        private string lname;
        private string address;
        private string bdate;
        private string sex;
        private Color textColor;
        private Font font;
        public Info(string fname, string lname,
            string address, string bdate, string sex)
        {
            InitializeComponent();
            textBox10.Text = fname;
            textBox9.Text = lname;
            textBox8.Text = address;
            textBox7.Text = bdate;
            textBox6.Text = sex;
            // MessageBox.Show(fname, lname);        

        }
        public Info()
        {
            InitializeComponent();


        }

        //Custom Method for changing text color
        public void ChangeColor(Color textcolor)
        {
            textColor = textcolor;

            label1.ForeColor = textColor;
            label10.ForeColor = textColor;
            label11.ForeColor = textColor;
            label12.ForeColor = textColor;
            label13.ForeColor = textColor;
            textBox10.ForeColor = textColor;
            textBox6.ForeColor = textColor;
            textBox7.ForeColor = textColor;
            textBox8.ForeColor = textColor;


        }

        public void ChangeFontVerdana()
        {
            label1.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            label10.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            label11.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            label12.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            label13.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            textBox10.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            textBox6.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            textBox7.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            textBox8.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
        }

        public void ChangeFontTimes()
        {
            label1.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            label10.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            label11.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            label12.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            label13.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            textBox10.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            textBox6.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            textBox7.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            textBox8.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
        }



    }
}
