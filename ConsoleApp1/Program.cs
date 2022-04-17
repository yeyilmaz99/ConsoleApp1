using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategori";
            int kategoriSayısı = 1500;
            double faizOranı = 1.45;
            bool isSignedIn = false;
            double dolarDun = 1.55;
            double dolarBugun = 1.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalıs butonu");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }

            

            if(isSignedIn == true) {
                Console.WriteLine("User is signed in");
            }
            else
            {
                Console.WriteLine("user is not signed in");
            }
            

            

        }
    }
}
 