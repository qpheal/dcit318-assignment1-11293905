using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side A: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side B: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side C: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Check if it can form a triangle first
        if (a + b > c && a + c > b && b + c > a)
        {
            if (a == b && b == c)
            {
                Console.WriteLine("This is an Equilateral triangle.");
            }
            else if (a == b || a == c || b == c)
            {
                Console.WriteLine("This is an Isosceles triangle.");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle.");
            }
        }
        else
        {
            Console.WriteLine("The given sides do not form a valid triangle.");
        }
    }
}
