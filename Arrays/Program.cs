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
            int[] rolls={0,0,0,0,0,0,0,0,0,0,0};
            Random dice = new Random();

            for (int i = 0; i < 36000; i++)
            {
                int rollOne = dice.Next(1, 7);
                int rollTwo = dice.Next(1, 7);
                //Console.WriteLine("{0}   {1}",rollOne, rollTwo);
                int roll= rollOne + rollTwo;

                switch (roll)
                {
                    case 2:
                        {
                            rolls[0]++;
                            break;
                        }
                    case 3:
                        {
                            rolls[1]++;
                            break;
                        }
                    case 4:
                        {
                            rolls[2]++;
                            break;
                        }
                    case 5:
                        {
                            rolls[3]++;
                            break;
                        }
                    case 6:
                        {
                            rolls[4]++;
                            break;
                        }
                    case 7:
                        {
                            rolls[5]++;
                            break;
                        }
                    case 8:
                        {
                            rolls[6]++;
                            break;
                        }
                    case 9:
                        {
                            rolls[7]++;
                            break;
                        }
                    case 10:
                        {
                            rolls[8]++;
                            break;
                        }
                    case 11:
                        {
                            rolls[9]++;
                            break;
                        }
                    case 12:
                        {
                            rolls[10]++;
                            break;
                        }

                }
            }
            Console.WriteLine(" Each number is displayed with the");
            Console.WriteLine(" number of times it was rolled:");
            Console.WriteLine(" 02: {0,4}", rolls[0]);
            Console.WriteLine(" 03: {0,3}", rolls[1]);
            Console.WriteLine(" 04: {0,3}", rolls[2]);
            Console.WriteLine(" 05: {0,3}", rolls[3]);
            Console.WriteLine(" 06: {0,3}", rolls[4]);
            Console.WriteLine(" 07: {0,3}", rolls[5]);
            Console.WriteLine(" 08: {0,3}", rolls[6]);
            Console.WriteLine(" 09: {0,3}", rolls[7]);
            Console.WriteLine(" 10: {0,3}", rolls[8]);
            Console.WriteLine(" 11: {0,3}", rolls[9]);
            Console.WriteLine(" 12: {0,4}", rolls[10]);

            Console.ReadKey();

            
            


        }
    }
}
