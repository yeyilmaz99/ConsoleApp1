using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Yunus", "Yagmur", "Emir", "Kevser" };

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);



            List<string> names2 = new List<string> { "Yagmur", "Kerem", "Kevser", "Halil" };
            foreach (string isim in names2)
            {
                Console.WriteLine(isim);
            }

            names2.Add("Emir");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);

            
        }
    }
}
