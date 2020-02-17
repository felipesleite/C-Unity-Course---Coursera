﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// //Assigment 2 - Nothing Like Blackjack!
    //Felipe S. Leite - 02/2020
    //*Most of this code was provided by Coursera Mentor, whith only a few lines modified.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Hello! This is a 'Nothing Like Blackjack' game! This program will deal 2 cards to 3 players.\n");

            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            Card cardP1 = deck.TakeTopCard();
            Card cardP2 = deck.TakeTopCard();
            Card cardP3 = deck.TakeTopCard();
            Card card2P1 = deck.TakeTopCard();
            Card card2P2 = deck.TakeTopCard();
            Card card2P3 = deck.TakeTopCard();

            // flip all the cards over
            cardP1.FlipOver();
            cardP2.FlipOver();
            cardP3.FlipOver();
            card2P1.FlipOver();
            card2P2.FlipOver();
            card2P3.FlipOver();

            // print the cards for player 1
            Console.WriteLine("Player 1 cards: " + cardP1.Rank + " of " + cardP1.Suit + " and " + card2P1.Rank + " of " + card2P1.Suit);

            // print the cards for player 2
            Console.WriteLine("Player 2 cards: " + cardP2.Rank + " of " + cardP2.Suit + " and " + card2P2.Rank + " of " + card2P2.Suit);

            // print the cards for player 3
            Console.WriteLine("Player 3 cards: " + cardP3.Rank + " of " + cardP3.Suit + " and " + card2P3.Rank + " of " + card2P3.Suit);

            Console.WriteLine();
        }
    }
}
