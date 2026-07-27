using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace A1Q4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Keep this line intact
            Console.WriteLine("===========================");

            // Insert your solution here.     
            Console.WriteLine("Welcome to the casino.");
            Console.WriteLine("Enter your Blackjack hand with cards separated by commas:");
            string userInput = Console.ReadLine()!;
            string[] hand = userInput.Split(",");
            int handValue = 0;
            int cardValue;
            if (hand.Length > 1 && hand.Length < 6)
            {
                bool fourSuitCheck = false;
                foreach (string card in hand)
                {
                    int currentCard = 0;
                    fourSuitCheck = (hand.Where(card => card == hand[currentCard]).Count() > 4);
                    currentCard++;
                }
                if (fourSuitCheck == false)
                {
                    foreach (string card in hand)
                    {
                        if (int.TryParse(card, out cardValue))
                        {
                            handValue = handValue + cardValue;
                        }

                        else
                        {
                            if (card == "K" || card == "Q" || card == "J")
                            {
                                cardValue = 10;
                                handValue = handValue + cardValue;
                            }
                            else if (card == "A")
                            {
                                cardValue = 11;
                                handValue = handValue + cardValue;
                            }
                        }
                    }
                    if (handValue > 21 && hand.Contains("A"))
                    {
                        handValue = handValue - 10;
                    }
    
                    if (handValue == 21)
                        {
                            Console.WriteLine("The score for this hand is " + handValue + ".");
                            Console.WriteLine("Congratulations! You have a Blackjack hand.");
                        }
                        else if (handValue > 21)
                        {
                            Console.WriteLine("You have gone bust.");
                        }
                        else
                        {
                            Console.WriteLine("The score for this hand is " + handValue + ".");
                        }
                }
                else
                {
                    Console.WriteLine("Error - There can only be 4 suits.");
                }
            }
            else
            {
                Console.WriteLine("Error - Invalid number of cards.");
            }
            // Keep this line intact
            Console.WriteLine("===========================");
        }
    }
}