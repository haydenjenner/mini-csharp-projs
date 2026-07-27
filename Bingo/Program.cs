using System;
using System.Data;
using System.Runtime.InteropServices;

namespace A1Q5
{
    class Program
    {
        static void Main(string[] args)
        {

            // Keep this line intact
            Console.WriteLine("===========================");

            // Insert your solution here.     
            char[,] card = { {'A', 'B', 'C', 'D', 'E' },
                            {'F','G','H','I','J' },
                            {'K','L','M','N','O' },
                            {'P','Q','R','S','T' },
                            {'U','V','W','Y','Z'} };
            Console.WriteLine("Welcome to the bingo hall.");
            Console.WriteLine("Below is your bingo card.");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(card[i, j]);

                    if (j < 4)
                        Console.Write(",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Rolling the bingo cage.");
            Console.WriteLine("Enter the letter from the bingo cage or 1 to exit:");
            var bingoBall = Console.ReadLine();
            char removeChar;
            do
            {
                if (char.TryParse(bingoBall, out removeChar))
                {
                    if (removeChar == '1')
                    {
                        Console.WriteLine("Ending the bingo game.");
                        break;
                    }
                    else
                    {
                        removeChar = Char.ToUpper(removeChar);
                        bool foundChar;
                        foundChar = false;
                        for (int j = 0; j < 5; j++)
                        {
                            for (int k = 0; k < 5; k++)
                            {
                                if (card[j, k] == removeChar)
                                {
                                    foundChar = true;
                                    card[j, k] = 'X';
                                }
                            }
                        }
                        if (foundChar == false)
                        {
                            if (int.TryParse(removeChar.ToString(), out int intVal))
                            {
                                Console.WriteLine("Error - Invalid value. Please try again.");
                            }
                            else
                            {
                                Console.WriteLine("Error - Value already entered. Please try again.");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error - Invalid value. Please try again.");
                }
                for (int col = 0; col < 5; col++)
                {
                    for (int row = 0; row < 5; row++)
                    {
                        Console.Write(card[col, row]);

                        if (row < 4)
                            Console.Write(",");
                    }
                    Console.WriteLine();
                }

                bool rowBingo = false;
                bool colBingo = false;
                bool forDiagBingo = true;
                bool bacDiagBingo = true;

                for (int col = 0; col < 5; col++)
                {
                    bool allX = true;
                    for (int row = 0; row < 5; row++)
                    {
                        if (card[col, row] != 'X')
                        {
                            allX = false;
                            break;
                        }
                    }
                    if (allX)
                    {
                        rowBingo = true;
                        break;
                    }
                }

                for (int row = 0; row < 5; row++)
                {
                    bool allX = true;
                    for (int col = 0; col < 5; col++)
                    {
                        if (card[col, row] != 'X')
                        {
                            allX = false;
                            break;
                        }
                    }
                    if (allX)
                    {
                        colBingo = true;
                        break;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    if (card[i, i] != 'X')
                    {
                        forDiagBingo = false;
                        break;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    if (card[i, 4 - i] != 'X')
                    {
                        bacDiagBingo = false;
                        break;
                    }
                }


                bool Bingo = rowBingo || colBingo || forDiagBingo || bacDiagBingo;
                if (Bingo)
                {
                    Console.WriteLine("BINGO!");
                    break;
                }
                Console.WriteLine();
            Console.WriteLine("Rolling the bingo cage.");
            Console.WriteLine("Enter the letter from the bingo cage or 1 to exit:");
            bingoBall = Console.ReadLine();
            } while (removeChar != '1');
            // Keep this line intact
                Console.WriteLine("===========================");
        }
    }
}