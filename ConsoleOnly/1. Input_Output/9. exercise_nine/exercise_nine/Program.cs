using System;

namespace exercise_nine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"car rental days:");
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine($"miles traveled:");
            int miles = int.Parse(Console.ReadLine());

            int tot = (days * 50) + (miles * 2);
            Console.WriteLine($"amount to pay for {miles} miles traveled and {days} days rented: {tot}");
        }
    }
}
