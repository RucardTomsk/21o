using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Ladies.Cards
{
    internal class Ladies_Hearts : Ladies
    {
        public Ladies_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._12_0;
        }
    }
}
