using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02.Static
{
    internal class Product
    {
        public static int TotalProducts = 0;

        public int Id { get; set; }

        public string Name { get; set; }
        public decimal Price { get; set; }


        // Call aoutomatically when an instance of the class is created or from a child class
        // Called only once per application lifetime
        // They are alaways private and parameterless
        // Can't be called directly
        // Used to initialize static members of the class or perform other setup tasks that need to be done only once

        static Product() 
        {
            Console.WriteLine("<<< Static Constructor Inside Product Class >>>");
            TotalProducts = 0;
        }

        public Product(string name , decimal price)
        {
            Id = TotalProducts;
            Name = name;
            Price = price;
            TotalProducts++;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Price: {Price:C}";
        }
    }
}
