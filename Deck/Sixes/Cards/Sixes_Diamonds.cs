using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sixes.Cards
{
    internal class Sixes_Diamonds : Sixes
    {
        public Sixes_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._6_1;
        }
    }
}
