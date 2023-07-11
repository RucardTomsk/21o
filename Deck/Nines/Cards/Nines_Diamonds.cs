using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Nines.Cards
{
    internal class Nines_Diamonds : Nines
    {
        public Nines_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._9_1;
        }
    }
}
