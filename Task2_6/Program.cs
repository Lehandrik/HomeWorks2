using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task2_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            Console.Write("Введите число : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int power = 0;

            while (num != a)
            {
                num /= a;
                power++;
            }
            Console.WriteLine("Даннное число является степенью двойки");
            Console.ReadLine();
        }

    }
}
