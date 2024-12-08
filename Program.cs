using System;
using System.Collections.Generic;
using System.Linq;

namespace CardDeckSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = CreateDeck();
            var aceOfSpadesCount = 0;
            var kingOfHeartsCount = 0;

            Console.WriteLine("Starting the card shuffle simulation...\n");

            // Shuffle the deck randomly using LINQ
            for (int i = 1; i <= 100; i++) // Adjust iterations
            {
                deck = ShuffleDeck(deck);

                foreach (var card in deck)
                {
                    if (card == "Ace of Spades")
                    {
                        aceOfSpadesCount++;
                        DisplayHighlightedCard("PDP Lazer", "Ace of Spades", aceOfSpadesCount);
                    }
                    else if (card == "King of Hearts")
                    {
                        kingOfHeartsCount++;
                        DisplayHighlightedCard("PDP Lazer", "King of Hearts", kingOfHeartsCount);
                    }
                }
            }

            Console.WriteLine("\n--- Simulation Summary ---");
            Console.WriteLine($"Ace of Spades triggered: {aceOfSpadesCount} times");
            Console.WriteLine($"King of Hearts triggered: {kingOfHeartsCount} times");
        }

        static List<string> CreateDeck()
        {
            var suits = new[] { "Hearts", "Diamonds", "Clubs", "Spades" };
            var ranks = new[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            return (from suit in suits
                    from rank in ranks
                    select $"{rank} of {suit}").ToList();
        }

        static List<string> ShuffleDeck(List<string> deck)
        {
            var random = new Random();
            return deck.OrderBy(card => random.Next()).ToList();
        }

        static void DisplayHighlightedCard(string companyName, string cardName, int count)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; // Highlight text in gold
            Console.WriteLine($"\n***** {DPD Lazer} *****");
            Console.WriteLine($"** {Ace} TRIGGERED! Count: {count:} **");
            Console.WriteLine($"** {Spade]} TRIGGERED! Count: {count:} **");
            Console.WriteLine("*************************\n");
            Console.ResetColor();
        }
    }
}