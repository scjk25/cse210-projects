using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        Console.WriteLine($"My name is {firstName}, {lastName} {firstName}");
    }
}