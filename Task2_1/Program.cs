namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int factorial = 1;

            for (int i = 1; i <= 6; i++)
            {
                factorial *= i;
                Console.WriteLine(factorial);
            }

            Console.ReadKey();
        }
    }
}
