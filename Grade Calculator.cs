using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("DCIT318 Assignment 1");
        Console.WriteLine("Select an option:");
        Console.WriteLine("1. Ticket Price Calculator");
        Console.WriteLine("2. Grade Calculator");
        Console.Write("Enter option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                TicketPriceCalculator();
                break;
            case "2":
                GradeCalculator();
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting...");
                break;
        }
    }

    static void TicketPriceCalculator()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");

        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        bool isValidAge = int.TryParse(input, out int age);

        if (!isValidAge || age < 0)
        {
            Console.WriteLine("Invalid age entered.");
            return;
        }

        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }

    static void GradeCalculator()
    {
        Console.WriteLine("\n--- Grade Calculator ---");

        Console.Write("Enter your grade (0 - 100): ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out int grade);

        if (!isValid || grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid input. Enter a number between 0 and 100.");
            return;
        }

        char letterGrade;

        if (grade >= 90)
            letterGrade = 'A';
        else if (grade >= 80)
            letterGrade = 'B';
        else if (grade >= 70)
            letterGrade = 'C';
        else if (grade >= 60)
            letterGrade = 'D';
        else
            letterGrade = 'F';

        Console.WriteLine($"Your letter grade is: {letterGrade}");
    }
}
