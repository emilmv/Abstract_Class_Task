using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task.Models
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public void Detail()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Price: {Price}");
            Console.WriteLine($"Product Count: {Count}");
        }
        public void Discount()
        {
            Console.WriteLine("Endirim %-ni daxil edin:");
            int.TryParse(Console.ReadLine(), out int discount);
            int newprice = Price - (Price * discount / 100);
            Console.WriteLine($"Endirimli giymet: {newprice}");
        }


    }
}
