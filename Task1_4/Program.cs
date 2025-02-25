namespace Task1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            int third = Convert.ToInt32(Console.ReadLine());

            int r = first;
            if ((first < second && second < third) || (first > second && second > third))
            {
                r = second;
            }
            else if ((second < third && third < first) || (second > third && third > first))
            {
                r = third;
            }

            Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}
