using System;

namespace day1
{
    class Program
    {
        static void Main()
        {
            string[] modules = System.IO.File.ReadAllLines(@"C:\Users\cedri\Downloads\test.txt");

            int res = 0;
            foreach (var module in modules)
            {

                res += CalculateFuel(Int32.Parse(module));

            }
            Console.WriteLine(res);
            System.Console.ReadKey();
        }
        static int CalculateFuel(int mass)
        {


            int massToCalc = (int)Math.Floor((double)mass / 3) - 2;
            int res = massToCalc;
            while (massToCalc > 0)
            {
                massToCalc = (int)Math.Floor((double)massToCalc / 3) - 2;
                if (massToCalc > 0)
                {
                    res += massToCalc;
                }
                else
                {
                    return res;

                }

            }

            return res;

        }
    }
}
