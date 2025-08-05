using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("DCIT318 Assignment 1");
        Console.WriteLine("Select a task:");
        Console.WriteLine("1. Ticket Price Calculator");
        Console.WriteLine("2. Grade Calculator");
        Console.WriteLine("3. Triangle Type Identifier");
        Console.Write("Enter an option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                TicketPriceCalculator();
                break;
            case "2":
                GradeCalculator();
                break;
            case "3":
                TriangleTypeIdentifier();
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

        Console.WriteLine($"Your grade is: {letterGrade}");
    }

    static void TriangleTypeIdentifier()
    {
        Console.WriteLine("\n--- Triangle Type Identifier ---");

        Console.Write("Enter side 1: ");
        string input1 = Console.ReadLine();
        Console.Write("Enter side 2: ");
        string input2 = Console.ReadLine();
        Console.Write("Enter side 3: ");
        string input3 = Console.ReadLine();

        bool isValid1 = double.TryParse(input1, out double side1);
        bool isValid2 = double.TryParse(input2, out double side2);
        bool isValid3 = double.TryParse(input3, out double side3);

        if (!isValid1 || !isValid2 || !isValid3 || side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter positive numbers only.");
            return;
        }

        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("The sides do not form a valid triangle.");
            return;
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
