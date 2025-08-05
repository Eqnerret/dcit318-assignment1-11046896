using System;
class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- DCIT318 Assignment 1 ---");
            Console.WriteLine("Select a task:");
            Console.WriteLine("1. Ticket Price Calculator");
            Console.WriteLine("2. Grade Calculator");
            Console.WriteLine("3. Triangle Type Identifier");
            Console.WriteLine("4. Exit");
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
                case "4":
                    running = false;
                    Console.WriteLine("Goodbye...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
    static void TicketPriceCalculator()
    {
        Console.WriteLine("\n--- Ticket Price Calculator ---");

        int age;
        while (true)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out age) && age >= 0)
                break;

            Console.WriteLine("Invalid age. Please enter a valid non-negative number.");
        }

        int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;

        Console.WriteLine($"Your ticket price is: GHC{ticketPrice}");
    }
    static void GradeCalculator()
    {
        Console.WriteLine("\n--- Grade Calculator ---");

        int grade;
        while (true)
        {
            Console.Write("Enter your grade (0 - 100): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
                break;

            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
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

        double side1 = GetValidSide("Enter side 1: ");
        double side2 = GetValidSide("Enter side 2: ");
        double side3 = GetValidSide("Enter side 3: ");

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
    static double GetValidSide(string prompt)
    {
        double side;
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out side) && side > 0)
                return side;

            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
    }
}
