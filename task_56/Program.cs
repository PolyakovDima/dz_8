using System;

class Program
{
    static void Main()
    {
        int[,] array = GenerateRandomArray(4, 5, 0, 32);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minRowIndex = FindRowWithMinSum(array);
        Console.WriteLine($"Строка с наименьшей суммой элементов: {minRowIndex + 1}");
    }

    // Метод для генерации случайного массива
    static int[,] GenerateRandomArray(int rows, int cols, int minValue, int maxValue)
    {
        Random random = new Random();
        int[,] array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return array;
    }

    // Метод для вывода массива на консоль
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    // Метод для нахождения строки с наименьшей суммой элементов
    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        int minRowIndex = 0;
        int minSum = int.MaxValue;

        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < cols; j++)
            {
                rowSum += array[i, j];
            }

            if (rowSum < minSum)
            {
                minSum = rowSum;
                minRowIndex = i;
            }
        }

        return minRowIndex;
    }
}