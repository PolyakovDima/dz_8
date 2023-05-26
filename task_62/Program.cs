using System;

class SpiralArray
{
    static void Main()
    {
        int[,] array = new int[4, 4];

        int value = 1;

        int topRow = 0;
        int bottomRow = array.GetLength(0) - 1;
        int leftColumn = 0;
        int rightColumn = array.GetLength(1) - 1;

        while (topRow <= bottomRow && leftColumn <= rightColumn)
        {

            for (int i = leftColumn; i <= rightColumn; i++)
            {
                array[topRow, i] = value;
                value++;
            }
            topRow++;


            for (int i = topRow; i <= bottomRow; i++)
            {
                array[i, rightColumn] = value;
                value++;
            }
            rightColumn--;


            if (topRow <= bottomRow)
            {
                for (int i = rightColumn; i >= leftColumn; i--)
                {
                    array[bottomRow, i] = value;
                    value++;
                }
                bottomRow--;
            }


            if (leftColumn <= rightColumn)
            {
                for (int i = bottomRow; i >= topRow; i--)
                {
                    array[i, leftColumn] = value;
                    value++;
                }
                leftColumn++;
            }
        }


        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}