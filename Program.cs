using System;

namespace TaskJunior3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int firstValueRandom = 0;
            int finishValueRandom = 10;
            int numberOfNumbers = 30;
            int lastIndex = 1;

            int[] numbers = new int [numberOfNumbers];
            Console.WriteLine(numbers.Length + " - кол-во элементов в самом массиве.\n\nМассив:\n");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(firstValueRandom, finishValueRandom);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nЛокальные максимумы:\n");

            if (numbers[0] > numbers[1])
            {
                Console.Write(numbers[0] + " ");
            }

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    Console.Write(numbers[i] + " ");
                }
            }

            if (numbers[^lastIndex] > numbers[^lastIndex] - 1)
            {
                Console.Write(numbers[^lastIndex] + " ");
            }
        }
    }
}
