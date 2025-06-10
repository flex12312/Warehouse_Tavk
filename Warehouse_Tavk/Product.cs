using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Warehouse_Tavk
{
    class Product
    {
        public string Name {  get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime ReceiptDate { get; set; }
        public Product(string name , DateTime expirationDate)
        {
            Name = name;
            ExpirationDate = expirationDate;
        }
        public bool CheckingExpirationDate()
        {
            return (ExpirationDate - DateTime.Today).TotalDays <= 3;
        }
    }
}
