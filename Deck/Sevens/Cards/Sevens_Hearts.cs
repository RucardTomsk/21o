using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sevens.Cards
{
    internal class Sevens_Hearts : Sevens
    {
        public Sevens_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._7_0;
        }
    }
}
