using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Task.Models
{
    internal class Product2
    {
        public int No { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }

        public Product2(int no, string name, int price, int count)
        {
            No = no;
            Name = name;
            Price = price;
            Count = count;
        }

    }

    internal class Book : Product2
    {
        public string Genre { get; set; }

        public Book(int no, string name, int price, int count, string genre) : base(no, name, price, count)
        {
            Genre=genre;
        }
    }


}
