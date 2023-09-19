using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
                string GradePercentageinput = Console.ReadLine();
                int number = int.Parse(GradePercentageinput);
                string Gradeletter = "";
                if (number >= 90)
                {
                    Gradeletter = "A";
                }
                else if (number >= 80)
                {
                    Gradeletter = "B";
                }
                else if (number >= 70)
                {
                    Gradeletter = "C";
                }
                else if (number >= 60)
                {
                    Gradeletter = "D";
                }
                else if (number < 60)
                {
                    Gradeletter = "F";
                }
                    Console.WriteLine($"Your letter grade is {Gradeletter}");
                if (number < 70)
                {
                    Console.WriteLine("You unfortunately are failing this course. Keep trying and eventually you will get it");
                }

    }


}