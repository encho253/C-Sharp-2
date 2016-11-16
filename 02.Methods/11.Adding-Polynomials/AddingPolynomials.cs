using System;
using System.Linq;

/// <summary>
/// Write a method that adds two polynomials. Represent them as arrays of their coefficients. 
/// Write a program that reads two polynomials and prints their sum.
/// Example explanation:
/// x2 + 5 = 1x2 + 0x + 5 => {5, 0, 1}
/// -3x2 + 4x + 7 = -3x2 + 4x + 7 => {7, 4, -3}
/// (x2 + 5) + (-3x2 + 4x + 7) = (-2x2 + 4x + 12) = -2x2 + 4x + 12 => {12, 4, -2}
/// </summary>
class AddingPolynomials
{
    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] firstArray = InputData(size);
        int[] secondArray = InputData(size);

        int[] sumPolynomials = SumOfThePolynomials(firstArray,secondArray,size);

        PrintAnswer(sumPolynomials);      
    }
    /// <summary>
    /// Inputs the data.
    /// </summary>
    /// <param name="size">The size.</param>
    /// <returns></returns>
    static int[] InputData(int size)
    {       
        int[] array = new int[size];

        string arrayAsString = Console.ReadLine();
        array = arrayAsString.Split().Select(n => Convert.ToInt32(n)).ToArray();

        return array;
    }

    /// <summary>
    /// Sums the of the polynomials.
    /// </summary>
    /// <param name="firstArray">The first array.</param>
    /// <param name="secondArray">The second array.</param>
    /// <param name="size">The size.</param>
    /// <returns></returns>
    static int[] SumOfThePolynomials(int[] firstArray,int[] secondArray,int size)
    {
        int[] sumPolynomials = new int[size];
         
        for (int i = 0; i < size; i++)
        {
            sumPolynomials[i] = firstArray[i] + secondArray[i];
        }
        return sumPolynomials;
    }

    /// <summary>
    /// Prints the answer.
    /// </summary>
    /// <param name="sumPolynomials">The sum polynomials.</param>
    static void PrintAnswer(int[] sumPolynomials)
    {
        foreach (var item in sumPolynomials)
        {
            Console.Write(item + " ");
        }
    }
}