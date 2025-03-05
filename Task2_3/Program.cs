using System;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень : ");
            int b = Convert.ToInt32(Console.ReadLine());

            int n = 1;
            for (int i = 0; i < b; i++)
            {
                n *= a;
            }

            Console.WriteLine("{0} ^ {1} = {2}", a, b, n);
            Console.ReadKey();

        }
    }
}
