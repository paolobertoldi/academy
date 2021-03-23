using System;

namespace exercise_two
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert the circle radius");
            double radius = double.Parse(Console.ReadLine());

            double circumference, area;
            area = 3.14 * Math.Pow(radius, 2);
            circumference = 2 * 3.14 * radius;

            Console.WriteLine($"area --> {area}");
            Console.WriteLine($"circumference --> {circumference}");
        }
    }
}
