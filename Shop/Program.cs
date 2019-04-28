using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetShop shop = new InternetShop();

            /*using(var context = new AppContext())
            {
                context.Products.Add(new Product()
                {
                    Name = "Селдь",
                    Cost = 1240
                });
                context.Products.Add(new Product()
                {
                    Name = "Пиво",
                    Cost = 2000
                });
                context.SaveChanges();
            }*/

            shop.Run();
            Console.ReadLine();
        }
    }
}
