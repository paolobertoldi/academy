using System;

namespace exercise_three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Determinate area and perimeter of a Rectangle Trapezoid;

            Console.WriteLine("insert the majro base");
            double maj_base = double.Parse(Console.ReadLine());
            Console.WriteLine("insert the minor base");
            double min_base = double.Parse(Console.ReadLine());
            Console.WriteLine("insert the height");
            double height = double.Parse(Console.ReadLine());

            double area, perimeter, obl_side;
            obl_side = Math.Sqrt(Math.Pow((maj_base - min_base), 2) + Math.Pow(height, 2));
            area = ((maj_base + min_base) * height) / 2;
            perimeter = (maj_base + min_base + obl_side + height)/2;

            Console.WriteLine($"area --> {area}");            
            Console.WriteLine($"perimeter --> {perimeter}");
        }
    }
}
