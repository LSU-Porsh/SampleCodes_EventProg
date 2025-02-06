using System;
using System.Windows.Forms;

namespace Project_ErrorHandling
{
    public partial class MessageBoxCondition : Form
    {
        public MessageBoxCondition()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    // Number 1
        //    MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1;
        //    if (MessageBox.Show("Selected item is already existing. Do you want to continue adding?", "XXX", MessageBoxButtons.YesNo, MessageBoxIcon.Question, defaultButton) == DialogResult.Yes)
        //    {
        //        MessageBox.Show("You Select Yes");
        //    }

        //    //Number 2
        //    bool myCondition = true;
        //    if (MessageBox.Show("Selected item is already existing. Do you want to continue adding?", "XXX", MessageBoxButtons.YesNo, MessageBoxIcon.Question, myCondition ? MessageBoxDefaultButton.Button2 : MessageBoxDefaultButton.Button1) == DialogResult.Yes)
        //    {
        //        // Code to execute if user clicks Yes
        //    }



        //    var result = MessageBox.Show("Message", "Title", MessageBoxButtons.YesNo);

        //    if (result == DialogResult.Yes)
        //    {
        //        label1.Text = "you select yest";
        //    }
        //    else
        //    {
        //        label1.Text = "you select no";
        //    }


        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Click Yes or No", "Form Closing", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                label1.Text = "you select yes";
            }
            else
            {
                label1.Text = "you select no";
            }

        }
    }
}
