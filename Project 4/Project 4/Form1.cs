using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Form1 : Form
    {
        private Color _color;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Color tcolor)
        {
            InitializeComponent();
            _color = tcolor;
            label1.ForeColor = _color;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Color_Button color = new Color_Button(Color.DeepPink);
            panel1.Controls.Clear();
            panel1.Controls.Add(color);
            color.Dock = DockStyle.Fill;

        }

    }
}
