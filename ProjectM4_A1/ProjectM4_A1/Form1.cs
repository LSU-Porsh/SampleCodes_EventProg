using System;
using System.Data;
using System.Windows.Forms;

namespace ProjectM4_A1
{
    public partial class Form1 : Form
    {
        DataTable productDB = new DataTable();
        int index;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            productDB.Columns.Add("ProductID", typeof(int));
            productDB.Columns.Add("Product Name", typeof(string));
            productDB.Columns.Add("Item Description", typeof(string));
            productDB.Columns.Add("Category", typeof(string));
            productDB.Columns.Add("Pricw", typeof(decimal));
            ProductGridView.DataSource = productDB;

        }

        private void AddCatbtn_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(CategoryCombo.Text))
            {
                MessageBox.Show("Please select a Category");
                return;

            }
            else if (!CategoryCombo.Items.Contains(CategoryCombo.Text))
            {
                CategoryCombo.Items.Add(CategoryCombo.Text);
            }
            else
            {
                MessageBox.Show("Already Added!.");

            }
        }
        string result;
        private void AddProbtn_Click(object sender, EventArgs e)
        {

            if (PIDtb.Text == "")
            {
                result = $"Product ID is required \n";
                MessageBox.Show(result);
                return;
            }
            else if (ProNametb.Text == "")
            {

                result = $"Product Name is required\n";
                MessageBox.Show(result);
                return;
            }
            else if (string.IsNullOrEmpty(CategoryCombo.Text))
            {
                result = $"Category is required \n";
                MessageBox.Show(result);
                return;
            }

            else if (!CategoryCombo.Items.Contains(CategoryCombo.Text))
            {
                MessageBox.Show(" Category does not exist!");
            }
            else if (PriceTb.Text == "")
            {
                result = $"Price is required\n";
                MessageBox.Show(result);
                return;
            }
            else
            {
                productDB.Rows.Add(PIDtb.Text, ProNametb.Text, ItemDestb.Text, CategoryCombo.Text, PriceTb.Text);
                ProductGridView.DataSource = productDB;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = ProductGridView.Rows[index];
            PIDtb.Text = row.Cells[0].Value.ToString();
            ProNametb.Text = row.Cells[1].Value.ToString();
            CategoryCombo.Text = row.Cells[2].Value.ToString();
            ItemDestb.Text = row.Cells[3].Value.ToString();
            PriceTb.Text = row.Cells[4].Value.ToString();
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            DataGridViewRow updateData = ProductGridView.Rows[index];
            updateData.Cells[0].Value = PIDtb.Text;
            updateData.Cells[1].Value = ProNametb.Text;
            updateData.Cells[2].Value = CategoryCombo.Text;
            updateData.Cells[3].Value = ItemDestb.Text;
            updateData.Cells[4].Value = PriceTb.Text;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            index = ProductGridView.CurrentRow.Index;

            ProductGridView.Rows.RemoveAt(index);
        }


        private void ProductGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = ProductGridView.CurrentRow.Index;

            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Cell clicked!");

            }

        }

        private void CategoryCombo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


//e: Refers to an object(usually an event argument) that contains information about the mouse event.
//Button: A property of the e object that represents the mouse button involved in the event.This line of code is used to display a context menu (usually a dropdown menu) associated with a control (in this case, a DataGridView).
//MouseButtons.Right: A constant value that corresponds to the right mouse button.
//If the condition is true (i.e., the right mouse button was clicked), the code inside the if block will execut
//This line of code is used to display a context menu(usually a dropdown menu) associated with a control(in this case, a DataGridView(ProductGridView)).
//new Point(e.X, e.Y): Specifies the position where the context menu should appear.
//e.X and e.Y are coordinates representing the mouse cursor’s position during the event.
//The context menu will appear at these coordinates relative to the dataGridView1 control.
// SubMenuDataGrid.Show(ProductGridView, new Point(-20, 10));