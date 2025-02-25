namespace Task1_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) Console.WriteLine("Да");
            else Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}
