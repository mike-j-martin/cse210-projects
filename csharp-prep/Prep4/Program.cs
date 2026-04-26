using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.WriteLine("Enter number: ");
            string word = Console.ReadLine();
            number = int.Parse(word);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int total = numbers.Sum();
        double ave = numbers.Average();
        int large = numbers.Max();
        Console.WriteLine($"the sum is {total}");
        Console.WriteLine($"the average is {ave}");
        Console.WriteLine($"the largest number is {large}");
    }
}