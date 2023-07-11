
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sixes.Cards
{
    internal class Sixes_Cross : Sixes
    {
        public Sixes_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._6_2;
        }
    }
}
