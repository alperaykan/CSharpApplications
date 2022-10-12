using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Models
{
    public class Product
    {
        public Product()
        {
            CreatedDate = DateTime.Now.Date;
        }

        public Product(string productName)
        {
            CreatedDate = DateTime.Now.Date;
            ProductName = productName;
        }

        public string ProductName { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
