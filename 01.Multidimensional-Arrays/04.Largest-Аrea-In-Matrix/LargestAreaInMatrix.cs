using System;

class LargestAreaInMatrix
{
    static void Main()
    {
        long[,] matrix = InputData();

        LargestArea(matrix);
    }

    static long[,] InputData()
    {
        string size = Console.ReadLine();
        string[] sizeString = size.Split(' ');
        long[,] matrix = new long[long.Parse(sizeString[0]), long.Parse(sizeString[1])];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = long.Parse(arrayNumbers[j]);
            }
        }
        return matrix;
    }

    static void LargestArea(long[,] matrix)
    {
        int area = 0;
        int bestArea = 0;
        int col = 0;
        int row = 0;
        int colJ = 0;
        int rowI = 0;
        bool firstTime = false;
        int counter = 0;
       
        while (counter <= (matrix.GetLength(0) * matrix.GetLength(1)))
        {
            firstTime = true;
            for (int i = rowI; i < matrix.GetLength(0); i++)
            {
                for (int j = colJ; j < matrix.GetLength(1); j++)
                {
                    if (firstTime)
                    {
                        if (i > row || j > col)
                        {
                            row = i;
                            col = j;
                            colJ = j;
                            rowI = i;
                            firstTime = false;
                        }
                    }
                    if ((i - 1) >= 0 && (i + 1) < (matrix.GetLength(0) - 1) && (j - 1) >= 0 && j < (matrix.GetLength(1) - 1))
                    {
                        
                    }
                    else if((i - 1) >= 0 && (i + 1) < (matrix.GetLength(0) - 1) && (j - 1) >= 0 && j < (matrix.GetLength(1) - 1))
                    {

                    }
                    else if ((i - 1) >= 0 && (i + 1) < (matrix.GetLength(0) - 1) && (j - 1) >= 0 && j < (matrix.GetLength(1) - 1))
                    {

                    }
                    else if ((i - 1) >= 0 && (i + 1) < (matrix.GetLength(0) - 1) && (j - 1) >= 0 && j < (matrix.GetLength(1) - 1))
                    {

                    }
                }
            }
            if (area > bestArea)
            {
                bestArea = area;
            }
            area = 0;

        }
        Console.WriteLine(bestArea);
    }
}