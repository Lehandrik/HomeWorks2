namespace Task2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите число больше 0: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите степень меньше 0: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a <= 0) Console.WriteLine("a должно быть больше 0.");
            if (b >= 0) Console.WriteLine("b должно быть меньше 0.");

            int n = b < 0 ? -b : b;
            double x = 1.0;

            for (int i = 0; i < n; i++)
            {
                x *= a;
            }

            x = 1.0 / x;

            Console.WriteLine("{0} ^ {1} = {2}", a, b, x);
            Console.ReadKey();
        }
    }
}
