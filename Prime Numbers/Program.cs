using System;

namespace A1Q3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep this line intact
            Console.WriteLine("===========================");     

            // Insert your solution here.     
            Console.WriteLine("Please enter a number greater than 1:");
            
            string userInput = Console.ReadLine();
            int num;
            
            if (int.TryParse(userInput, out num) && num > 1)
            {

                List<int> primeNums = new List<int>();

                for (int belowNum = 2; belowNum <= num; belowNum++)
                {
                    bool prime = true;
                    for (int listDividend = 2; listDividend <= Math.Sqrt(belowNum); listDividend++)
                    {
                        if (belowNum % listDividend == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime == true)
                    {
                        primeNums.Add(belowNum);
                    }
                }


                foreach (int number in primeNums)
                    {
                        Console.WriteLine(number + " is a prime number.");
                    }

                if (primeNums.Count == 1)
                    {
                        Console.WriteLine("There is 1 prime number between 1 and "+num+" (inclusive).");
                    }
                else if (primeNums.Count > 1)
                    {
                        Console.WriteLine("There are "+primeNums.Count+" prime numbers between 1 and "+num+" (inclusive).");
                    }

            }

            else
            {
                Console.WriteLine("The given number is invalid.");
            }
            // Keep this line intact
            Console.WriteLine("===========================");
        }
    }
}