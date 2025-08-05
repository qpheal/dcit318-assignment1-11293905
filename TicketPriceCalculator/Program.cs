using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();
        int age;

        if (int.TryParse(input, out age) && age >= 0)
        {
            int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Your ticket price is: GHC {ticketPrice}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }
    }
}
