using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeckOfCardsAPI.Models
{
    public class Deck
    {
        public string DeckID { get; set; }
        public Card[] Cards { get; set; }
    }

    public class Card
    {
       public Uri Image { get; set; }
       public string Value { get; set; }
       public string Suit { get; set; }
    }
}
