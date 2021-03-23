using System;

namespace exercize_eight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many dvd do you want to buy?");
            int dvd = int.Parse(Console.ReadLine());

            int costperdvd = 10;
            int tot = dvd * costperdvd;

            Console.WriteLine($"total cost for {dvd} dvds: {tot}");
        }
    }
}
