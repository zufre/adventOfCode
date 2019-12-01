using System;

namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] modules = System.IO.File.ReadAllLines("test.txt");

                int res = 0;
                foreach (var module in modules)
                {
                    res += calculateFuel(Int32.Parse(module));
                }

            Console.WriteLine(res);
            System.Console.ReadKey();
        }
        static int calculateFuel(int mass)
        {
            return  (int)Math.Floor((double)mass / 3) - 2;
        }
    }
}
