using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProductApp
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }


    public class ProductManager
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(int id, string name, double price)
        {

            Product newProduct = new Product()
            {
                ProductId = id,
                ProductName = name,
                ProductPrice = price,
            };

            products.Add(newProduct);

        }

        public void DisplayProducts(DataGridView dataGridView)
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = products;
            dataGridView.Refresh();

        }

        public Product FindProductById(int id)
        {
            foreach (var product in products)
            {
                if (product.ProductId == id)
                {
                    Console.WriteLine($"\nID: {product.ProductId}, Name: {product.ProductName}, Price: {product.ProductPrice}");
                    return product;
                }
            }

            return null; // return null if no product found with the given id
        }

    }
}
