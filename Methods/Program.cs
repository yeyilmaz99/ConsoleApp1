using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Functions.Product product1 = new Functions.Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Description = "Amasya elması";
            product1.Id = 1;




            Functions.Product product2 = new Functions.Product();
            product2.Name = "Karpuz";
            product2.Price = 20;
            product2.Description = "Diyarbakır karpuzu";
            product2.Id = 2;



            Functions.Product[] products = new Functions.Product[] { product1, product2 };

            foreach (Functions.Product product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("---------Functions------------");


            //intance - örnek (CartManager'ın bir intance'ını oluşturup istediğimiz yerde kullanabiliyoruz)

            Functions.CartManager cartManager = new Functions.CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);

            

        }
    }
}
