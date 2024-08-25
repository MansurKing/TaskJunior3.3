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
            int numberOfLines = 30;
            int firstIndex = 0;
            int secondIndex = 1;
            int penultimateIndex = 28;
            int lastIndex = 29;

            int[] array = new int [numberOfLines];
            Console.WriteLine(array.Length + " - кол-во элементов в самом массиве.\n\nМассив:\n");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(firstValueRandom, finishValueRandom);
                Console.Write(array[i] + " ");
            }

            Console.WriteLine("\n\nЛокальные максимумы:\n");

            if (array[firstIndex] > array[secondIndex])
            {
                Console.Write(array[firstIndex] + " ");
            }

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    Console.Write(array[i] + " ");
                }
            }

            if (array[lastIndex] > array[penultimateIndex])
            {
                Console.Write(array[lastIndex] + " ");
            }
        }
    }
}
