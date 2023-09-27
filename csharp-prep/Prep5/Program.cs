using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        int number = PromptUserNumber();
        int SquaredNumber = SquareNumber(number);
        string name = PromptUserName();

        DisplayResult(name, SquaredNumber);



    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program");
    }
    
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string firstlastname = Console.ReadLine();
        return firstlastname;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int favoritenumber = int.Parse(Console.ReadLine());
        return favoritenumber;
    }

    static int SquareNumber( int favoritenumber)
    {
        int SquaredNumber = favoritenumber * favoritenumber;
        return SquaredNumber;
    }

    static void DisplayResult(String name, int SquaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {SquaredNumber}");
    }

}