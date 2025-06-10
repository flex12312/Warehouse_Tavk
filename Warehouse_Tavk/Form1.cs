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
    public partial class Form1 : Form
    {
        private List<Product> allProducts = new List<Product>
        {
            new Product("Молоко", DateTime.Today.AddDays(5)),
            new Product("Йогурт", DateTime.Today.AddDays(2)),
            new Product("Хлеб", DateTime.Today.AddDays(1))
        };
        public Form1()
        {
            InitializeComponent();
            foreach (var product in allProducts)
                listBoxProducts.Items.Add(product.Name);
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
