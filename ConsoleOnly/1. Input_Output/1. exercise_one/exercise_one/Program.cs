using System;

namespace exercise_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insert square side");
            double side = double.Parse(Console.ReadLine());

            double area, perimeter;
            area = Math.Pow(side, 2);
            perimeter = side * 4;

            Console.WriteLine($"area --> {area}");
            Console.WriteLine($"perimeter --> {perimeter}");
        }
    }
}
