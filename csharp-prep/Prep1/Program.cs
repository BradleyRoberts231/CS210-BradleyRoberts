using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name?");
        string first_nameBR = Console.ReadLine();
                Console.WriteLine("What is your last name?");
        string last_nameBR = Console.ReadLine();

        Console.WriteLine($"Your name is {last_nameBR}, {first_nameBR} {last_nameBR}.");
    }
}