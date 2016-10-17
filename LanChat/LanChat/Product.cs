using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanChat
{
    public class Product
    {
        public string Name { get; set; }
        public int Amount { get; set; }

        public Product()
        {
            
        }
        public Product(string name, int amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
