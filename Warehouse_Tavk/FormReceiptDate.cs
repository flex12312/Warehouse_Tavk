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
    public partial class FormReceiptDate : Form
    {
        ListBox ListBox;
        Product Product;
        List<Product> Products;
        public FormReceiptDate(ListBox listBox, Product product,List<Product> products)
        {
            InitializeComponent();
            ListBox = listBox;
            Product = product;
            Products = products;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > DateTime.Today)
            {
                MessageBox.Show("Ошибка! Дата поступления не может быть в будущем!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ListBox.Items.Add(Product.ToString());
                Product.SetReceiptDate(dateTimePicker1.Value);
                Products.Add(Product);
                this.Close();
            }
        }
    }
}
