using System;

class LargestAreaInMatrix
{
    static void Main()
    {
        int[,] matrix = InputData();

        LargestArea(matrix);
    }

    static int[,] InputData()
    {
        string size = Console.ReadLine();
        string[] sizeString = size.Split(' ');
        int[,] matrix = new int[int.Parse(sizeString[0]), int.Parse(sizeString[1])];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            string numbers = Console.ReadLine();
            string[] arrayNumbers = numbers.Split(' ');

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(arrayNumbers[j]);
            }
        }
        return matrix;
    }
    static void LargestArea(int[,] matrix)
    {
        int lenghtRow = matrix.GetLength(0);
        int lenghtCol = matrix.GetLength(1);
        int area = 1;
        int bestArea = 1;
        int row = 0;
        int col = 0;
        int rowNow = 0;
        int colNow = 0;
        bool holdDown = false;
        int counter = 0;

        bool[,] boolMatrix = new bool[lenghtRow, lenghtCol];

        while (true)
        {
            if (col + 1 < lenghtCol) //right
            {
                if (matrix[row, col] == matrix[row, col + 1] && boolMatrix[row, col + 1] == false)
                {               
                    boolMatrix[row, col] = true;
                    col++;
                    area++;
                    holdDown = true;
                }
            }
            if (col - 1 >= 0) //left
            {
                if (matrix[row, col] == matrix[row, col - 1] && boolMatrix[row, col - 1] == false)
                {                   
                    boolMatrix[row, col] = true;
                    col--;
                    area++;
                    holdDown = true;
                }
            }
            if (row + 1 < lenghtRow) //down
            {
                if (matrix[row, col] == matrix[row + 1, col] && boolMatrix[row + 1, col] == false)
                {                  
                    boolMatrix[row, col] = true;
                    row++;
                    area++;
                    holdDown = true;
                }
            }
            if (row - 1 >= 0) //up
            {
                if (matrix[row, col] == matrix[row - 1, col] && boolMatrix[row - 1, col] == false)
                {              
                    boolMatrix[row, col] = true;
                    row--;
                    area++;
                    holdDown = true;
                }
            }
            if (area > bestArea)
            {
                bestArea = area;
            }
            if (holdDown == false)
            {
                if (row == rowNow && col == colNow)
                {
                    if (colNow + 1 == lenghtCol)
                    {
                        if (rowNow + 1 < lenghtRow)
                        {
                            rowNow++;
                            colNow = 0;
                        }
                    }
                    else
                    {
                        colNow++;
                    }
                }
                col = colNow;
                row = rowNow;
            }
            holdDown = false;
        }
    }
}