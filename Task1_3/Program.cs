namespace Task1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = Convert.ToInt32(Console.ReadLine());
            int secondnumber = Convert.ToInt32(Console.ReadLine());
            int thirdnumber = Convert.ToInt32(Console.ReadLine());
            int fourthnumber = Convert.ToInt32(Console.ReadLine());

            int max = (firstnumber > secondnumber) ? firstnumber : secondnumber;
            max = (max > thirdnumber) ? max : thirdnumber;
            max = (max > fourthnumber) ? max : fourthnumber;

            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
