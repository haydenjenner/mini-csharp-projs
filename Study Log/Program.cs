using System;
using System.Linq.Expressions;

namespace A1Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Keep this line intact 
            Console.WriteLine("===========================");

         
            // Insert your solution here.
            Console.WriteLine("Please enter the number of weeks you have studied this semester:");

            int weeksStudy = Convert.ToInt32(Console.ReadLine());

            if (weeksStudy > 13)
            {
                Console.WriteLine("Invalid number of weeks entered.");
            }
            else if (weeksStudy < 0)
            {
                Console.WriteLine("Invalid number of weeks entered.");
            }
            else
            {
                int hrsStudy = 0;

                for (int i = 1; i <= weeksStudy; i = i + 1)
                {
                    Console.WriteLine("Please enter the number of hours you have studied for week " + i + ":");

                    int weeksHrs = Convert.ToInt32(Console.ReadLine());
                    if (weeksHrs < 0)
                    {
                        weeksHrs = 0;
                    }
                    hrsStudy = hrsStudy + weeksHrs;
                }

                int daysStudy = hrsStudy / 24;

                int hrsRemainder = hrsStudy - daysStudy * 24;
                Console.WriteLine("This semester you have studied " + hrsStudy + " hours, which is the equivalent of " + daysStudy + " days and " + hrsRemainder + " hours.");
            }

            // Keep this line intact 
            Console.WriteLine("===========================");
        }
    }
}