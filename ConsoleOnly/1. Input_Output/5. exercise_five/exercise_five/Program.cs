using System;

namespace exercise_five
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given two points on the cartesian plane calculate the distance between the two;

            Console.WriteLine("insert the x value for the point A");
            double xA = double.Parse(Console.ReadLine());
            Console.WriteLine("insert the y value for the point A");
            double yA = double.Parse(Console.ReadLine());
            Console.WriteLine("insert the x value for the point B");
            double xB = double.Parse(Console.ReadLine());
            Console.WriteLine("insert the y value for the point B");
            double yB = double.Parse(Console.ReadLine());

            double distance;
            distance = Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yA - yB), 2));
            Console.WriteLine($"The distance between [{xA},{yA}] and [{xB},{yB}] is {distance}");
        }
    }
}
