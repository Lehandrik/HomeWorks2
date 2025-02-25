namespace Task1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int thirdnumber = Convert.ToInt32(Console.ReadLine());

            int max = (firstnumber > secondnumber) ? firstnumber : secondnumber;
            max = (max > thirdnumber) ? max : thirdnumber;
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
