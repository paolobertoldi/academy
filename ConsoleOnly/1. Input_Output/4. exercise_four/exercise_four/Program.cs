using System;

namespace exercise_four
{
    class Program
    {
        static void Main(string[] args)
        {
            //Given a number find the next three after it;

            Console.WriteLine("insert a number");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"[{num}] --> {num + 1}, {num + 2}, {num + 3}");
        }
    }
}
