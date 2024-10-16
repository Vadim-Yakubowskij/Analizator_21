using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizator_21
{
    public class Deck
    {
        protected List<string> deck = new List<string> { "2", "2", "2", "2", "3", "3", "3", "4", "4", "4", "4", "4", "5", "5", "5", "5", "6", "6", "6", "6", "7", "7", "7", "7", "8", "8", "8", "8", "9", "9", "9", "9", "j", "j", "j", "j", "q", "q", "q", "q", "k", "k", "k", "k", "a", "a", "a", "a" };
        protected string GiveCard()
        {
            Random rnd = new Random();
            int cardindex = rnd.Next(0, deck.Count);
            string card = deck[cardindex];
            deck.RemoveAt(cardindex);
            return card;
        }
    }
}
