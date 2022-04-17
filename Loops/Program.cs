using System;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] {"yazılım kampı 1","yazılım kampı 2", "yazılım kampı 3" };


            for (int i = 1; i <= 10; i+=2)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for loop ended");    

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("foreach loop ended");


        }
    }
}
