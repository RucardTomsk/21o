
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Dozens.Cards
{
    internal class Dozens_Cross : Dozens
    {
        public Dozens_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._10_2;
        }
    }
}
