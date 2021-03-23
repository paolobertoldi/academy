using System;

namespace exercise_seven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insert x value --> ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("insert y value --> ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("insert y value --> ");
            double z = double.Parse(Console.ReadLine());

            double avg;
            avg = (x + y + z) / 3;

            Console.WriteLine($"the average is {avg}");
        }
    }
}
