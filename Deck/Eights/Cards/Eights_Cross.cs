using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Eights.Cards
{
    internal class Eights_Cross : Eights
    {
        public Eights_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._8_2;
        }
    }
}
