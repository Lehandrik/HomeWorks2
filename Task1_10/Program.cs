namespace Task1_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 10 == 1) Console.Write("Мы построили {0} дом", n);
            if (n % 10 >= 2 && n % 10 <= 4) Console.Write("Мы построили {0} дома ", n);
            if (n % 10 >= 5 && n % 10 <= 20) Console.Write("Мы построили {0} домов ", n);

            Console.ReadKey();
        }
    }
}
