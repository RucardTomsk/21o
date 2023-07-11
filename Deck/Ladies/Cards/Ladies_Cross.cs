
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Ladies.Cards
{
    internal class Ladies_Cross : Ladies
    {
        public Ladies_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._12_2;
        }
    }
}
