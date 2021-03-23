using System;

namespace exercise_eleven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("wall height:");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("wall width");
            double width = double.Parse(Console.ReadLine());

            double wallArea = (height * width), literNeeded,
                timeNeeded, tot, literMargin = 10, paintCost, job, tax = 22;

            timeNeeded = wallArea / 15;
            literNeeded = (wallArea * (100 + literMargin)) / 100;
            paintCost = ((literNeeded * 13) * (100 + tax)) / 100;
            job = timeNeeded * 25;
            tot = paintCost + job;
            Console.WriteLine($"total cost: {tot}");
        }
    }
}
