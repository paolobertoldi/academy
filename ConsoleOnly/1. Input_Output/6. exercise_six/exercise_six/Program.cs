using System;

namespace exercise_six
{
    class Program
    {
        static void Main(string[] args)
        {
            //[Point A]
            Console.WriteLine("About [Point A]");
            Console.Write("X value: ");
            double xA = double.Parse(Console.ReadLine());
            Console.Write("Y value: ");
            double yA = double.Parse(Console.ReadLine());
            
            //[Point B]
            Console.WriteLine("\nAbout [Point B]");
            Console.Write("X value: ");
            double xB = double.Parse(Console.ReadLine());
            Console.Write("Y value: ");
            double yB = double.Parse(Console.ReadLine());

            //[Point C]
            Console.WriteLine("\nAbout [Point C]");
            Console.Write("X value: ");
            double xC = double.Parse(Console.ReadLine());
            Console.Write("Y value: ");
            double yC = double.Parse(Console.ReadLine());

            double area;
            area = (((xA * (yB - yC)) + (xB * (yC - yA)) + (xC * (yA - yB))) / 2)*(-1);
            Console.Write($"area --> {area}");
        }
    }
}
