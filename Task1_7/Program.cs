namespace Task1_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a >= 10 && a < 100) Console.WriteLine("Да");
            else Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}
