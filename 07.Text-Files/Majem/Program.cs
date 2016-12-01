using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < 5; i++)
        {
            sum += IsInt();
        }
        Console.WriteLine(sum);
    }
    static int IsInt()
    {
        int number = 0;
        do
        {
            string text = Console.ReadLine();
            if (int.TryParse(text,out number) == false)
            {
                Console.WriteLine("Enter valid number");
            }
            else
            {
                number = int.Parse(text);
                break;
            }
        } while (true);

        return number;
    }
}