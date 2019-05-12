using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = int.Parse(Console.ReadLine());
            int sum = 0;
            
            bool devideOrNot = false;
            for (int cycle = 1; cycle <= total; cycle++)
            {
                int cycleCopier = cycle;
                while (cycle > 0)
                {
                    sum += cycle % 10;
                    cycle = cycle / 10;
                }
                devideOrNot = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", cycleCopier, devideOrNot);
                sum = 0;
                cycle = cycleCopier;
            }

        }
    }
}
