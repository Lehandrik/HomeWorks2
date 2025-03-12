namespace Task5_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем массив из 10 случайных чисел в диапазоне [-20, 20]
            int[] numbers = new int[10];
            Random random = new Random();

            // Заполняем массив случайными числами
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(-20, 21); // Генерация случайного числа от -20 до 20
            }

            // Подсчет положительных, отрицательных и нулевых элементов
            int positiveCount = 0; // Счетчик положительных чисел
            int negativeCount = 0; // Счетчик отрицательных чисел
            int zeroCount = 0;     // Счетчик нулевых элементов

            foreach (int number in numbers)
            {
                if (number > 0)
                    positiveCount++;
                else if (number < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            // Вывод массива на экран без использования string
            Console.WriteLine("Массив случайных чисел:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
                if (i < numbers.Length - 1)
                    Console.Write(", ");
            }
            Console.WriteLine(); // Переход на новую строку

            // Вывод результатов
            Console.WriteLine($"Количество положительных чисел: {positiveCount}");
            Console.WriteLine($"Количество отрицательных чисел: {negativeCount}");
            Console.WriteLine($"Количество нулевых элементов: {zeroCount}");
        }
    }
}
