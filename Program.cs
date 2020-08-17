using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck1 = new Deck();
            deck1.Shuffle();
            for (int i = 0; i < 2; i++)
            {
                Console.Write("{0,-19}", deck1.DealCard());

            }


        }
    }

    public class Card
    {
        private string suit;
        private string face;

        public Card(string cardFace, string cardSuit)
        {

            face = cardFace;
            suit = cardSuit;
        }
        public override string ToString()
        {
            return face + "of" + suit;
        }
    }


    public class Deck
    {
        private Card[] deck;
        private int currentCard;
        private const int NumberOfCards = 52;
        private Random randomNumber;

        public Deck()
        {
            string[] suit = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] face = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "King,", "Jack", "Queen" };
            deck = new Card[NumberOfCards];
            currentCard = 0;
            randomNumber = new Random();
            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(face[count % 11], suit[count / 13]);
        }
        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumber.Next(NumberOfCards);
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;

            }
        }
        public Card DealCard()
        {
            if (currentCard < deck.Length)
                return deck[currentCard++];
            else
                return null;
        }
    }
}











