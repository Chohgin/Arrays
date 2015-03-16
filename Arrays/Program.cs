using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rolls={};
            Random dice = new Random();

            for (int i = 0; i < 36000; i++)
            {
                int rollOne = dice.Next(1, 6);
                int rollTwo = dice.Next(1, 6);

                rolls[i] = rollOne + rollTwo;
            }

            Console.WriteLine("02: {0}");
            Console.WriteLine("03: {0}");
            Console.WriteLine("04: {0}");
            Console.WriteLine("05: {0}");
            Console.WriteLine("06: {0}");
            Console.WriteLine("07: {0}");
            Console.WriteLine("08: {0}");
            Console.WriteLine("09: {0}");
            Console.WriteLine("10: {0}");
            Console.WriteLine("11: {0}");
            Console.WriteLine("12: {0}");

            
            


        }
    }
}
