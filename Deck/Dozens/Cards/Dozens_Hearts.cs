using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Dozens.Cards
{
    internal class Dozens_Hearts : Dozens
    {
        public Dozens_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._10_0;
        }
    }
}
