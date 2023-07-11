using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Eights.Cards
{
    internal class Eights_Diamonds : Eights
    {
        public Eights_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._8_1;
        }
    }
}
