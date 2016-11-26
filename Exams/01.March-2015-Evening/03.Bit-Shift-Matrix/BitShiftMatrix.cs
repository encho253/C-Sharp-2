using System;
using System.Linq;
using System.Numerics;

/// <summary>
/// You are given rectangular matrix. The matrix is filled with numbers that are power of 2, as follows:
///  The bottom left corner holds the value 1
///  The next cell above holds value of 2, the next cell above holds of 4, etc…
///  The second cell the bottom row holds a value of 2, the cell next to it holds a value of 4
/// You have a pawn on the field.The pawn can only move to the cells that directly above, below it or right/left of it.
/// We have four directions UP, DOWN, LEFT, RIGHT.
/// Given that initially the pawn starts at the bottom left corner and a list of cells that the pawn must reach calculate the s
/// um of the cells that the pawn has to go through.
/// The value of each cell is calculated only once, i.e. if the pawn visits the same cell more than once, 
/// its value is added to the result only the first time (the value is collected).
/// The top row is at position 0, the bottommost row is at position ROWS – 1.
/// The pawn goes from one cell to the other, following the rules:
///  First go to the target column
///  Second go to the target row
/// </summary>
class BitShiftMatrix
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int r = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine()); 
        BigInteger[,] matrix = GenerateMatrix(r,c);
        BigInteger sum = CalculateSumOfPawn(r,c,matrix);
        Console.WriteLine(sum);          
    }
    /// <summary>
    /// Generates the matrix.
    /// </summary>
    /// <param name="r">The r.</param>
    /// <param name="c">The c.</param>
    /// <returns></returns>
    static BigInteger[,] GenerateMatrix(int r,int c)
    {
        BigInteger[,] matrix = new BigInteger[r,c];       
        BigInteger counterCol = 1;
        BigInteger counterRow = 1;

        for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
        {
            for (int j = 0; j < matrix.GetLength(1) ; j++)
            {
                matrix[i, j] = counterRow;
                matrix[i, j] *= counterCol;
                counterCol *= 2; 
            }
            counterRow *= 2;
            counterCol = 1;
        }
        return matrix;
    }
    /// <summary>
    /// Calculates the sum of pawn.
    /// </summary>
    /// <param name="r">The r.</param>
    /// <param name="c">The c.</param>
    /// <param name="matrix">The matrix.</param>
    /// <returns></returns>
    static BigInteger CalculateSumOfPawn(int r ,int c,BigInteger[,] matrix)
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        BigInteger sum = 0;
        int lastCol = 0;
        int lastRow = r - 1;
        bool[,] boolMatrix = new bool[r,c];

        for (int i = 0; i < n; i++)
        {          
            int coef = Math.Max(r, c);
            int row = numbers[i] / coef;
            int col = numbers[i] % coef;

            if (lastCol <= col)
            {
                for (int k = lastCol; k <= col; k++)
                {
                    if (boolMatrix[lastRow,k] == false)
                    {
                        sum += matrix[lastRow,k];
                        boolMatrix[lastRow, k] = true;
                    }
                    lastCol = k;
                }
            }
            else if (lastCol >= col)
            {
                for (int j = lastCol; j >= col; j--)
                {
                    if (boolMatrix[lastRow, j] == false)
                    {
                        sum += matrix[lastRow, j];
                        boolMatrix[lastRow, j] = true;
                    }
                    lastCol = j;
                }
            }
            if (lastRow <= row)
            {
                for (int k = lastRow; k <= row; k++)
                {
                    if (boolMatrix[k, lastCol] == false)
                    {
                        sum += matrix[k,lastCol];
                        boolMatrix[k,lastCol] = true;
                    }
                    lastRow = k;
                }
            }
            else if (lastRow >= row)
            {
                for (int j = lastRow; j >= row; j--)
                {
                    if (boolMatrix[j,lastCol] == false)
                    {
                        sum += matrix[j, lastCol];
                        boolMatrix[j, lastCol] = true;
                    }
                    lastRow = j;
                }
            }
        }
        return sum;
    }
}