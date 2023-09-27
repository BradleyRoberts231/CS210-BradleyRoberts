using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        List<int> list = new List<int>();
        int input = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        while (input != 0)
        {
            Console.WriteLine("Input number to add to list: ");
            input = int.Parse(Console.ReadLine());
            list.Add(input);
        }
        
        int sum = 0;
        foreach (int number in list)
        {
            sum += number;
        }

        float avg = ((float)sum) / list.Count;

        int max = list[0];
        foreach (int number in list)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum of the inputs is {sum}");
        Console.WriteLine($"The average of the inputs is {avg}");
        Console.WriteLine($"The maximum of the inputs is {max}");



    }
}