using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Warehouse_Tavk
{
    public class Product
    {
        public string Name {  get; set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime ReceiptDate { get; private set; }
        public Product(string name , DateTime expirationDate)
        {
            Name = name;
            ExpirationDate = expirationDate;
        }
        public bool CheckingExpirationDate()
        {
            return (ExpirationDate - DateTime.Today).TotalDays <= 3;
        }
        public void SetReceiptDate(DateTime receiptDate)
        {
            ReceiptDate = receiptDate;
        }
        public override string ToString()
        {
            return $"{Name} {ExpirationDate.ToShortDateString()}";
        }
    }
}
