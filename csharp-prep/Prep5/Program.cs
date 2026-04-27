using System;
using System.Runtime.CompilerServices;

class Program
{
static void Displaymessage()
    {
        Console.WriteLine("welcome to the Program!");
    }
    static string username()
    {
        Console.WriteLine("What is your full name? ");
        string name = Console.ReadLine();
        return name;
    }
    static int number()
    {
        Console.WriteLine("what is your favorite whole number? ");
        string word = Console.ReadLine();
        int num = int.Parse(word);
        return num;
    }
    static int birthyear()
    {
        Console.WriteLine("what year were you born? ");
        string word = Console.ReadLine();
        int year = int.Parse(word);
        return year;
    }
    static void square(string name, int num)
    {
        int squared = num * num;
        Console.WriteLine($"{name}, the square of your favorite number is {squared}.");
    }
    static void age(string name, int year)
    {
        int new_age = 2026 - year;
        Console.WriteLine($"{name} you will be {new_age} by the end of the year.");
    }
    static void Main(string[] args)
    {
        Displaymessage();
        string full_name = username();
        int Fav_num = number();
        int old_year = birthyear();
        square(full_name, Fav_num);
        age(full_name, old_year);
    }
}