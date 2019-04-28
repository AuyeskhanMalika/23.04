using System;

namespace Shop
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public Cart Cart { get; set; } = new Cart();
        public void Print()
        {
            Console.WriteLine($"Login    : {Login}");
            Console.WriteLine($"Password : {Password}");
        }
    }
}