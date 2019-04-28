using System;

namespace Shop
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} : {Cost}");
        }
    }
}