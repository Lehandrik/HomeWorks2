namespace Task1_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int r = Convert.ToInt32(Console.ReadLine());
            int s = Convert.ToInt32(Console.ReadLine());

            if (a * b > (r * s) + (p * q)) Console.WriteLine("На прямоугольном участке с размерами {0}м на {1}м могут уместиться два дома", a, b);
            else Console.WriteLine("На прямоугольном участке с размерами {0}м на {1}м не могут уместиться два дома", a, b);

            Console.ReadKey();
        }
    }
}
