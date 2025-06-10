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
        public FormMain()
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
