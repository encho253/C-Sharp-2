using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingAbsoluteDifferences
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
    
        for (int i = 0; i < number; i++)
        {
            var line = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            bool isTrue = true;

            for (int j = 2; j < line.Length; j++)
            {
                long lastAbsDif = Math.Abs(line[j - 2] - line[j - 1]);
                long currentAbsDif = Math.Abs(line[j - 1] - line[j]);               

                if (lastAbsDif > currentAbsDif || currentAbsDif - lastAbsDif > 1)
                {
                    isTrue = false;
                    break;
                }
            }
            Console.WriteLine(isTrue);           
        }       
    }
}