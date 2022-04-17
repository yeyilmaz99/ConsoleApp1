using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    class CartManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Product has been added to cart : " + product.Name);
        }

        public void Add2(string productName, string description, double price)
        {

        }


    }
}
