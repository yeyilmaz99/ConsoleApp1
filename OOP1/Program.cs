using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 600;
            product1.UnitsInStock = 3;



            Product product2 = new Product 
            { 
                Id = 2, 
                CategoryId=3, 
                ProductName= "Kalem", 
                UnitPrice =  30, 
                UnitsInStock = 10 
            };


            //ProductManager productManager = new ProductManager();
            //productManager.Add(product1);
            //Console.WriteLine(product1);
            // Çıktı "Kamera" olacaktır // referans tip adresteki değer değişiyor


            //int sayi = 100;
            //productManager.Add2(sayi);
            // çıktı 100 olacaktır. // değer tip

            //int, bool, double... = değer tip
            // dizi, class, abstract class, interface = referans tip



        }
    }
}
