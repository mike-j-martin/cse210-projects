using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();

        int magic = randomgenerator.Next(1,101);
        int guess = 0;

        while (guess != magic)
        {
            Console.Write("what number is your guess? ");
            string numbertwo = Console.ReadLine();
            guess = int.Parse(numbertwo);
            if(guess > magic)
            {
                Console.WriteLine("lower");
            }
            else if(guess < magic)
            {
                Console.WriteLine("higher");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}