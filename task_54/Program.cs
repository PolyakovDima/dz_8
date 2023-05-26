using System;

class ArraySorting
{
    static void Main()
    {
        int[,] array = GenerateRandomArray(3, 4, 0, 32);

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        SortRowsDescending(array);

        Console.WriteLine("Массив с упорядоченными строками:");
        PrintArray(array);
    }

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

    static void SortRowsDescending(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 1; j < cols; j++)
            {
                int key = array[i, j];
                int k = j - 1;

                while (k >= 0 && array[i, k] < key)
                {
                    array[i, k + 1] = array[i, k];
                    k--;
                }

                array[i, k + 1] = key;
            }
        }
    }
}