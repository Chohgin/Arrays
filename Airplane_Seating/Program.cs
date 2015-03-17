using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane_Seating
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] seats = new bool[10];
            int index = 0;
            int indexTwo = 5;
            int choice = 0;
            while (choice != 3)
            {
                if (choice == 0)
                { 
            //Menu
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Welcome to Middle of Nowhere flights automated reservation system.");
            Console.WriteLine("Please select an option from the list below, or press 3 to exit:");
            Console.WriteLine("1. First Class");
            Console.WriteLine("2. Economy Class");
            Console.WriteLine("3. Exit");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            }
            
                //Switch for initial choice
                switch (choice)
                {
                    case 1:
                        {
                            //assigning seating
                            if (index < 5)
                            {
                                Console.WriteLine("Thank you for choosing First Class.");
                                seats[index] = true;
                                index++;
                                choice = 0;
                            }
                            else if (index >=5 && indexTwo >= 10)
                            {
                                Console.WriteLine("Both classes are full. The next flight leaves in three hours.");
                                Console.WriteLine("Press any key to exit.");

                                Console.ReadKey();
                                choice = 3;
                            }
                                //while index>5 but indexTwo <10
                            else if (index >= 5)
                            {
                                Console.WriteLine("First Class is full. Check for a seat in Economy Class?");
                                Console.WriteLine("Choose 1 for Economy Class or 2 to Exit program");
                                int choiceTwo = Convert.ToInt32(Console.ReadLine());

                                switch (choiceTwo)
                                {
                                    case 1:
                                        {
                                            choice = 2;
                                            break;
                                        }
                                    case 2:
                                        {
                                            choice = 3;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                    case 2:
                        {
                            if (indexTwo < 10)
                            {
                                Console.WriteLine("Thank you for choosing Economy Class");
                                seats[indexTwo] = true;
                                indexTwo++;
                                choice = 0;
                            }
                            else if (index >= 5 && indexTwo >= 10)
                            {
                                Console.WriteLine("Both classes are full. The next flight leaves in three hours.");
                                Console.WriteLine("Press any key to exit.");

                                Console.ReadKey();
                                choice = 3;
                            }
                            else if (index >= 10)
                            {
                                Console.WriteLine("Economy Class is full. Check for a seat in First Class?");
                                Console.WriteLine("Choose 1 for First Class or 2 to Exit program");
                                int choiceTwo = Convert.ToInt32(Console.ReadLine());

                                switch (choiceTwo)
                                {
                                    case 1:
                                        {
                                            choice = 1;
                                            break;
                                        }
                                    case 2:
                                        {
                                            choice = 3;
                                            break;
                                        }
                                }
                            }
                            break;
                        }
                            
                    case 3:
                        {
                            Console.WriteLine("Thank you for choosing Middle of Nowhere flights.");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                            break;
                        }

                }
            }

                    


        }
       
    }
}
