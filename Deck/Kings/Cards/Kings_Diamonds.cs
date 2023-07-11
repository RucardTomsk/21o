using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Kings.Cards
{
    internal class Kings_Diamonds : Kings
    {
        public Kings_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._13_1;
        }
    }
}
