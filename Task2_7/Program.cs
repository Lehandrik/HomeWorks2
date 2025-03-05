namespace Task2_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (num > 0)
            {
                i++;
                num /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа : {0}", i);
            Console.ReadLine();
        }
    }
}
