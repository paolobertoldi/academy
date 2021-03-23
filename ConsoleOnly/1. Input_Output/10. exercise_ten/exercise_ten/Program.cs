using System;

namespace exercise_ten
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("how many b/w pages:");
            int bw = int.Parse(Console.ReadLine());
            Console.WriteLine("how colored pages:");
            int colored = int.Parse(Console.ReadLine());

            int coverprice = 10;
            double tot = coverprice + (bw * 0.10) + (colored * 0.15);
            Console.WriteLine($"amount to pay for {bw} b/w pages and {colored} colored pages is: {tot}");
        }
    }
}
