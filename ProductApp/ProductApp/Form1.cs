using System;
using System.Windows.Forms;

namespace ProductApp
{
    public partial class frmMainWindow : Form
    {
        ProductManager productlist = new ProductManager();
        public frmMainWindow()
        {
            InitializeComponent();

        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            // Display any existing products in the DataGridView

            productlist.DisplayProducts(ProductGrid);

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            string name = tbProdName.Text;
            int numId = Convert.ToInt32(tbProdID.Text);
            double numPrice = Convert.ToDouble(tbProdPrice.Text);


            productlist.AddProduct(numId, name, numPrice);

            productlist.DisplayProducts(ProductGrid);

            tbProdID.Text = " ";
            tbProdName.Text = " ";
            tbProdPrice.Text = " ";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void lblFindProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
