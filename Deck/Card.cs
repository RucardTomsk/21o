using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck
{
    public interface card_i
    {
        
    }
    internal class Card: card_i
    {
        public ColorCard Color;
        public Cost Cost;
        public Suit Suit;
        public bool Closed;
        public Bitmap Image;
        public Card()
        {

        }
    }
}