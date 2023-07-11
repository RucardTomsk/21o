using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sixes.Cards
{
    internal class Sixes_Hearts : Sixes
    {
        public Sixes_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._6_0;
        }
    }
}
