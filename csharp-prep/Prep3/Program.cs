using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 100);
        
        int responsenumber = 0;
        while (responsenumber != magicnumber)
            {
            Console.WriteLine("What is your guess?");
            string guessresponse = Console.ReadLine();
                responsenumber = int.Parse(guessresponse);


                if (responsenumber > magicnumber)
                    {Console.WriteLine("Lower");}
                else if (responsenumber < magicnumber)
                    {Console.WriteLine("Higher");}
                else if (responsenumber == magicnumber)
                    {Console.WriteLine("You have guessed the magic number!");}
        }

    }
}