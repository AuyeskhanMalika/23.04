using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Cart : Entity
    {
        public Cart()
        {
            Products = new List<Product>();
        }
        public ICollection<Product> Products { get; set; }
    }
}
