using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_conditons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int condition1;
            //int condition2;
            

            //// if sample
            //condition1 = 2;
            //condition2 = 3;
            //if (condition1 == 1)
            //{
            //    Console.WriteLine("condition1 is true");
            //}
            //else if (condition2 == 4)
            //{
            //    Console.WriteLine("condition2 is true");
            //}
            //else
            //{
            //    Console.WriteLine("Neither condition is true");
            //}

            //Console.WriteLine("This line executes regardless of condition.");


            //Switch sample
            int switchCondition;

            switchCondition = 5;

            switch (switchCondition)
            {
                case 1:
                    Console.WriteLine("value is 1");
                    break;

                case 2:
                    Console.WriteLine("value is 2");
                    break;

                case 3:
                    Console.WriteLine("value is 3");
                    break;

                default:
                    Console.WriteLine("value is " + switchCondition);
                    break;
            }

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
