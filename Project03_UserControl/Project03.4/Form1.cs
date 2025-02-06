namespace Project03._4
{
    public partial class Form1 : Form
    {
        RiddleUserControl form2 = new RiddleUserControl();
        CalculatorUserControl sample = new CalculatorUserControl(); // instance of usercontrol1


        //this is the constructor
        public Form1()
        {
            InitializeComponent();

        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Arial", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("Arial", label1.Font.Size, label1.Font.Style);
            //label3.Font = new Font("Arial", label1.Font.Size, label1.Font.Style);
            //label4.Font = new Font("Arial", label1.Font.Size, label1.Font.Style);
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            //label3.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
            //label4.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
        }

        private void verdanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            //label3.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            //label4.Font = new Font("Verdana", label1.Font.Size, label1.Font.Style);
            button1.Font = new Font("Verdana", button1.Font.Size, button1.Font.Style);
        }

        private void forteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Forte", label1.Font.Size, label1.Font.Style);
            label2.Font = new Font("Forte", label1.Font.Size, label1.Font.Style);
            //label3.Font = new Font("Forte", label1.Font.Size, label1.Font.Style);
            //label4.Font = new Font("Forte", label1.Font.Size, label1.Font.Style);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
            label2.ForeColor = Color.Red;
            //label3.ForeColor = Color.Red;
            //label4.ForeColor = Color.Red;

        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Orange;
            label2.ForeColor = Color.Orange;
            //label3.ForeColor = Color.Orange;
            //label4.ForeColor = Color.Orange;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            //label3.ForeColor = Color.Yellow;
            //label4.ForeColor = Color.Yellow;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            //label3.ForeColor = Color.Green;
            //label4.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
            label2.ForeColor = Color.Blue;
            //label3.ForeColor = Color.Blue;
            //label4.ForeColor = Color.Blue;
        }

        private void indigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Indigo;
            label2.ForeColor = Color.Indigo;
            //label3.ForeColor = Color.Indigo;
            //label4.ForeColor = Color.Indigo;
        }

        private void violetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Violet;
            label2.ForeColor = Color.Violet;
            //label3.ForeColor = Color.Violet;
            //label4.ForeColor = Color.Violet;
        }



        private void verySmallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 5, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 5, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 5, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 5, label1.Font.Style);
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 7, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 7, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 7, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 7, label1.Font.Style);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 12, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 12, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 12, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 12, label1.Font.Style);
        }

        private void fontSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 18, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 18, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 18, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 18, label1.Font.Style);
        }

        private void extraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 20, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 20, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 20, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 20, label1.Font.Style);
        }

        private void extraExtraLargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.FontFamily, 25, label1.Font.Style);
            label2.Font = new Font(label2.Font.FontFamily, 25, label1.Font.Style);
            //label3.Font = new Font(label3.Font.FontFamily, 25, label1.Font.Style);
            //label4.Font = new Font(label4.Font.FontFamily, 25, label1.Font.Style);
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(236, 230, 224);
        }

        private void orangeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(233, 211, 196);
        }

        private void yellowToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(204, 194, 192);
        }

        private void radioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); //to clear the panel
            panel1.Controls.Add(form2);
            //panel1.Controls.Add(sample);
            form2.Dock = DockStyle.Fill;


        }

        private void plainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\User\source\repos\Project03.4\Project03.4\p1.jpg");
            this.BackgroundImage = myimage;
        }

        private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(@"C:\Users\User\source\repos\Project03.4\Project03.4\p3.jpg");
            this.BackgroundImage = myimage;
        }

        private void riddleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear(); //to clear the panel
            panel1.Controls.Add(sample);
            sample.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = true;
        }
    }
}