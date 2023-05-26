using System;

class Program
{
    static void Main()
    {
        int[,] matrix1 = GenerateRandomMatrix(2, 2, 1, 10);
        int[,] matrix2 = GenerateRandomMatrix(2, 2, 1, 10);

        int[,] productMatrix = MultiplyMatrices(matrix1, matrix2);

        Console.WriteLine("Матрица 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Матрица 2:");
        PrintMatrix(matrix2);

        Console.WriteLine("Произведение матриц:");
        PrintMatrix(productMatrix);
    }

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
    {
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        if (cols1 != rows2)
        {
            throw new ArgumentException("Невозможно умножить матрицы. Количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
        }

        int[,] product = new int[rows1, cols2];

        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                int sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                product[i, j] = sum;
            }
        }

        return product;
    }

    static int[,] GenerateRandomMatrix(int rows, int cols, int minValue, int maxValue)
    {
        int[,] matrix = new int[rows, cols];
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = random.Next(minValue, maxValue + 1);
            }
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}