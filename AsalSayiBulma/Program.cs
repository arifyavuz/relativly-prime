using System;

namespace AsalSayiBulma
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ilk Sayiyi Giriniz:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ikinci Sayiyi Giriniz:");
            int b = int.Parse(Console.ReadLine());
            for (int i = 2; i <= a && i <= b;i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    Console.WriteLine("Tam bolunen Sayilar");
                    break;
                }
                else
                {
                    Console.WriteLine("Sayilar Aralarinda Asaldir");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
