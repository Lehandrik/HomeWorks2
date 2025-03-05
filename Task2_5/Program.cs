namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            do
            {
                Console.Write("Введите число от 20 до 60: ");
                int num = Convert.ToInt32(Console.ReadLine());
                i = num;

            } while (i < 20 || i > 60); Console.Write("Вы попали в диапазон от 20 до 60");

            Console.ReadKey();
        }
    }
}
