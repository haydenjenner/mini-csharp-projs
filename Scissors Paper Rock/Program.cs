using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;

namespace A1Q2
{

    class Program
    {

        static void Main(string[] args)
        {

            // Keep this line intact
            Console.WriteLine("==========================="); 

            // Insert your solution here.
            Console.WriteLine("Welcome to a game of scissors, paper, rock.");
            Console.WriteLine("Use S for scissors, P for paper, and R for rock.");
            Console.WriteLine("Please enter player 1's choice:");
            char playerOne = Char.ToUpper(char.Parse(Console.ReadLine()!));
            Console.WriteLine("Please enter player 2's choice:");
            char playerTwo = Char.ToUpper(char.Parse(Console.ReadLine()!));

            string explain;
            string winner;

            if (playerOne == 'S')
            {
                if (playerTwo == 'S')
                {
                    explain = "It's a draw.";
                    winner = "";
                }
                else if (playerTwo == 'P')
                {
                    explain = "Scissors cuts paper.";
                    winner = "Player 1 wins!";
                }
                else if (playerTwo == 'R')
                {
                    explain = "Rock smashes scissors.";
                    winner = "Player 2 wins!";
                }
                else
                {
                    explain = "Error:";
                    winner = "There was incorrect input.";
                }

            }
            else if (playerOne == 'P')
            {
                if (playerTwo == 'S')
                {
                    explain = "Scissors cuts paper.";
                    winner = "Player 2 wins!";
                }
                else if (playerTwo == 'P')
                {
                    explain = "It's a draw.";
                    winner = "";
                }
                else if (playerTwo == 'R')
                {
                    explain = "Paper covers rock.";
                    winner = "Player 1 wins!";
                }
                else
                {
                    explain = "Error:";
                    winner = "There was incorrect input.";
                }
            }

            else if (playerOne == 'R')
            {
                if (playerTwo == 'S')
                {
                    explain = "Rock smashes scissors.";
                    winner = "Player 1 wins!";
                }
                else if (playerTwo == 'P')
                {
                    explain = "Paper covers rock.";
                    winner = "Player 2 wins!";
                }
                else if (playerTwo == 'R')
                {
                    explain = "It's a draw.";
                    winner = "";
                }
                else
                {
                    explain = "Error:";
                    winner = "There was incorrect input.";
                }
            }

            else
            {
                explain = "Error:";
                winner = "There was incorrect input.";
            }
            Console.WriteLine(explain + " " + winner);
            // Keep this line intact
                Console.WriteLine("===========================");
        }
    }
}