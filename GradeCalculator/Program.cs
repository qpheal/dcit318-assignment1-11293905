﻿using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade (0 - 100): ");
        string input = Console.ReadLine();
        int grade;

        if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
        {
            string letterGrade;

            if (grade >= 80)
                letterGrade = "A";
            else if (grade >= 75)
                letterGrade = "B+";
            else if (grade >= 70)
                letterGrade = "B";
            else if (grade >= 65)
                letterGrade = "C+";
            else if (grade >= 60)
                letterGrade = "C";
            else if (grade >= 55)
                letterGrade = "D";
            else if (grade >= 50)
                letterGrade = "E";
            else
                letterGrade = "F";

            Console.WriteLine($"Your letter grade is: {letterGrade}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }
    }
}
