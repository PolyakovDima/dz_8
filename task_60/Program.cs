using System;

class Program
{
    static void Main()
    {
        int[,,] array = GenerateUniqueTwoDigitArray(2, 2, 2);

        Console.WriteLine("Трехмерный массив:");
        PrintArrayRandomly(array);
    }

    static int[,,] GenerateUniqueTwoDigitArray(int length1, int length2, int length3)
    {
        int[,,] array = new int[length1, length2, length3];
        Random random = new Random();

        int minValue = 10;
        int maxValue = 99;

        int totalElements = length1 * length2 * length3;
        int[] uniqueValues = new int[totalElements];

        for (int i = 0; i < totalElements; i++)
        {
            uniqueValues[i] = random.Next(minValue, maxValue + 1);
        }

        for (int i = 0; i < length1; i++)
        {
            for (int j = 0; j < length2; j++)
            {
                for (int k = 0; k < length3; k++)
                {
                    int randomIndex = random.Next(0, totalElements);
                    array[i, j, k] = uniqueValues[randomIndex];
                    uniqueValues[randomIndex] = uniqueValues[totalElements - 1];
                    totalElements--;
                }
            }
        }

        return array;
    }

    static void PrintArrayRandomly(int[,,] array)
    {
        int length1 = array.GetLength(0);
        int length2 = array.GetLength(1);
        int length3 = array.GetLength(2);

        Random random = new Random();

        for (int count = length1 * length2 * length3; count > 0; count--)
        {
            int i = random.Next(0, length1);
            int j = random.Next(0, length2);
            int k = random.Next(0, length3);

            Console.WriteLine($"Индексы [{i}, {j}, {k}]: {array[i, j, k]}");
        }
    }
}