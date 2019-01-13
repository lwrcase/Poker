using System.Collections.Generic;

namespace Poker
{
    /// <summary>
    /// Deck controller for implenting deck interface methods.
    /// </summary>
    public class Deck : IDeck
    {
        /// <summary>
        /// 
        /// </summary>
        List<Card> _cards;
        /// <summary>
        /// 
        /// </summary>
        Queue<Card> Cards { get; set; }
        public int CardsInQueue
        {
            get
            {
                return Cards.Count;
            }
        }
        public Deck()
        {
            _cards = GenerateAllCards();
            _cards.Shuffle();
            Cards = new Queue<Card>(_cards);
        }
        /// <summary>
        /// Generates a 52 card list of Card objects.
        /// </summary>
        /// <returns>List of Card objects.</returns>
        private List<Card> GenerateAllCards()
        {
            return new List<Card>
            {
                new Card
                {
                    Image = Properties.Resources.AC,
                    Name = "Ace of Clubs",
                    Ordinal = 14,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources.AD,
                    Name = "Ace of Diamonds",
                    Ordinal = 14,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources.AH,
                    Name = "Ace of Hearts",
                    Ordinal = 14,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources.AS,
                    Name = "Ace of Spades",
                    Ordinal = 14,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources.KC,
                    Name = "King of Clubs",
                    Ordinal = 13,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources.KD,
                    Name = "King of Diamonds",
                    Ordinal = 13,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources.KH,
                    Name = "King of Hearts",
                    Ordinal = 13,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources.KS,
                    Name = "King of Spades",
                    Ordinal = 13,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources.QC,
                    Name = "Queen of Clubs",
                    Ordinal = 12,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources.QD,
                    Name = "Queen of Diamonds",
                    Ordinal = 12,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources.QH,
                    Name = "Queen of Hearts",
                    Ordinal = 12,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources.QS,
                    Name = "Queen of Spades",
                    Ordinal = 12,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources.JC,
                    Name = "Jack of Clubs",
                    Ordinal = 11,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources.JD,
                    Name = "Jack of Diamonds",
                    Ordinal = 11,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources.JH,
                    Name = "Jack of Hearts",
                    Ordinal = 11,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources.JS,
                    Name = "Jack of Spades",
                    Ordinal = 11,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._10C,
                    Name = "10 of Clubs",
                    Ordinal = 10,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._10D,
                    Name = "10 of Diamonds",
                    Ordinal = 10,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._10H,
                    Name = "10 of Hearts",
                    Ordinal = 10,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._10S,
                    Name = "10 of Spades",
                    Ordinal = 10,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._9C,
                    Name = "9 of Clubs",
                    Ordinal = 9,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._9D,
                    Name = "9 of Diamonds",
                    Ordinal = 9,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._9H,
                    Name = "9 of Hearts",
                    Ordinal = 9,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._9S,
                    Name = "9 of Spades",
                    Ordinal = 9,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._8C,
                    Name = "8 of Clubs",
                    Ordinal = 8,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._8D,
                    Name = "8 of Diamonds",
                    Ordinal = 8,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._8H,
                    Name = "8 of Hearts",
                    Ordinal = 8,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._8S,
                    Name = "8 of Spades",
                    Ordinal = 8,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._7C,
                    Name = "7 of Clubs",
                    Ordinal = 7,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._7D,
                    Name = "7 of Diamonds",
                    Ordinal = 7,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._7H,
                    Name = "7 of Hearts",
                    Ordinal = 7,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._7S,
                    Name = "7 of Spades",
                    Ordinal = 7,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._6C,
                    Name = "6 of Clubs",
                    Ordinal = 6,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._6D,
                    Name = "6 of Diamonds",
                    Ordinal = 6,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._6H,
                    Name = "6 of Hearts",
                    Ordinal = 6,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._6S,
                    Name = "6 of Spades",
                    Ordinal = 6,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._5C,
                    Name = "5 of Clubs",
                    Ordinal = 5,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._5D,
                    Name = "5 of Diamonds",
                    Ordinal = 5,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._5H,
                    Name = "5 of Hearts",
                    Ordinal = 5,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._5S,
                    Name = "5 of Spades",
                    Ordinal = 5,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._4C,
                    Name = "4 of Clubs",
                    Ordinal = 4,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._4D,
                    Name = "4 of Diamonds",
                    Ordinal = 4,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._4H,
                    Name = "4 of Hearts",
                    Ordinal = 4,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._4S,
                    Name = "4 of Spades",
                    Ordinal = 4,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._3C,
                    Name = "3 of Clubs",
                    Ordinal = 3,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._3D,
                    Name = "3 of Diamonds",
                    Ordinal = 3,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._3H,
                    Name = "3 of Hearts",
                    Ordinal = 3,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._3S,
                    Name = "3 of Spades",
                    Ordinal = 3,
                    Suit = Suit.Spade
                },
                new Card
                {
                    Image = Properties.Resources._2C,
                    Name = "2 of Clubs",
                    Ordinal = 2,
                    Suit = Suit.Club
                },
                new Card
                {
                    Image = Properties.Resources._2D,
                    Name = "2 of Diamonds",
                    Ordinal = 2,
                    Suit = Suit.Diamond
                },
                new Card
                {
                    Image = Properties.Resources._2H,
                    Name = "2 of Hearts",
                    Ordinal = 2,
                    Suit = Suit.Heart
                },
                new Card
                {
                    Image = Properties.Resources._2S,
                    Name = "2 of Spades",
                    Ordinal = 2,
                    Suit = Suit.Spade
                }
            };
        }
        public Card GetNextCard()
        {
            return Cards.Dequeue();
        }
        public void NewDeck()
        {
            _cards.Clear();
            _cards = GenerateAllCards();
            _cards.Shuffle();
            Cards = new Queue<Card>(_cards);
        }
        public Card Peek()
        {
            return Cards.Count > 0 ? Cards.Peek() : null;
        }
    }
}
