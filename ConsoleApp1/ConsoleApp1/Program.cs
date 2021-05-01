using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            int counter=0;

            Console.WriteLine($" Summary of range is equal to : {RangeCounter(2, sum, 1, counter)}");
            Console.ReadKey();
        }
        static int RangeCounter(int power, int sum, int step, int counter)
        {
            
            step *= 2;
            sum = step;
            sum += step;
            counter += sum;

            if (power == 10)
            {
                return counter;
            }
            else
            {
                return RangeCounter(power + 1, sum, step, counter);
            }
        }
    }
}
