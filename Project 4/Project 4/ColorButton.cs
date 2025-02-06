using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_4
{
    public partial class Color_Button : UserControl
    {
        private Color _color;
        public Color_Button(Color textColor)
        {
            InitializeComponent();
            _color = textColor;
            label1.ForeColor = _color;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }
    }
}
