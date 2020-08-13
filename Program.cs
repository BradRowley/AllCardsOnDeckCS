using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new List<string>() { "Ace of Diamonds", "Ace of Hearts", "Ace of Clubs", "Ace of Spades", "2 of Clubs", "2 of Spades", "2 of Diamonds", "2 of Hearts", "3 of Clubs", "3 of Spades", "3 of Diamonds", "3 of Hearts", "4 of Clubs", "4 of Spades", "4 of Diamonds", "4 of Hearts", "5 of Clubs", "5 of Spades", "5 of Diamonds", "5 of Hearts", "6 of Clubs", "6 of Spades", "6 of Diamonds", "6 of Hearts", "7 of Clubs", "7 of Spades", "7 of Diamonds", "7 of Hearts", "8 of Clubs", "8 of Spades", "8 of Hearts", "8 of Diamonds", "9 of Clubs", "9 of Spades", "9 of Diamonds", "9 of Hearts", "10 of Clubs", "10 of Spades", "10 of Diamonds", "10 of Hearts", "Jack of Clubs", "Jack of Spades", "Jack of Diamonds", "Jack of Hearts", "Queen of Clubs", "Queen of Spades", "Queen of Diamonds", "Queen of Hearts", "King of Clubs", "King of Spades", "King of Diamonds", "King of Hearts" };
            var n = deck.Count();
            // Console.WriteLine($"There is {n} in our deck of cards")
            for (var index = 0; index < 2; index++)
            {
                var randomNumberGenerator = new Random();
                index = randomNumberGenerator.Next(52);
                Console.WriteLine(deck[index]);











            }




            //  for rightIndex from n - 1 down to 1 do:
            // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex

            // Now swap the values at rightIndex and leftIndex by doing this:
            //   leftCard = the value from deck[rightIndex]
            //   rightChard = the value from deck[leftIndex]
            //   deck[rightIndex] = rightChard
            //   deck[leftIndex] = leftCard






        }
    }
}
