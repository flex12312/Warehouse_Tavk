using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse_Tavk
{
    public partial class FormMain : Form
    {
        private List<Product> allProducts = new List<Product>
        {
            new Product("Молоко", DateTime.Today.AddDays(5)),
            new Product("Йогурт", DateTime.Today.AddDays(2)),
            new Product("Хлеб", DateTime.Today.AddDays(3)),
            new Product("Сметана", DateTime.Today.AddDays(6)),
            new Product("Творог", DateTime.Today.AddDays(12)),
            new Product("Хлеб", DateTime.Today.AddDays(4)),
            new Product("Стасик", DateTime.Today.AddDays(20000)),
            new Product("Тушенка", DateTime.Today.AddDays(1826)),
        };
        private List<Product> products = new List<Product>();
        public FormMain()
        {
            InitializeComponent();
            foreach (var product in allProducts)
                listBoxProducts.Items.Add(product.ToString());
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = allProducts[listBoxProducts.SelectedIndex];
            FormReceiptDate formReceiptDate = new FormReceiptDate(listBoxWarehouse, product,products);
            formReceiptDate.ShowDialog();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            DeleteExpiredProducts();
        }

        private void DeleteExpiredProducts()
        {
            for (int i = products.Count - 1; i >= 0; i--)
                if (products[i].CheckingExpirationDate())
                    products.RemoveAt(i);

            listBoxWarehouse.Items.Clear();
            foreach (var product in products)
                listBoxWarehouse.Items.Add(product.ToString());
        }
    }
}
