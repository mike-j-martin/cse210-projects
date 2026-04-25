using System;
using System.Diagnostics.Tracing;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade of the student? ");
        string number = Console.ReadLine();
        float grade = float.Parse(number);
        string graduate;
        string Letter;
        
        if (grade >= 70)
        {
            graduate = "Passed";
        }
        else
        {
            graduate = "Failed";
        }
        
        if (grade >= 90)
        {
            Letter = "A";
        }
        else if (grade >= 80)
        {
            Letter = "B";
        }
        else if (grade >= 70)
        {
            Letter = "C";
        }
        else if (grade >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }
        Console.WriteLine($"You have {graduate} due to a letter grade of {Letter}");
    }
}