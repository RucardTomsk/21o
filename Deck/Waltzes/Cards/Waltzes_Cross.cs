
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Waltzes.Cards
{
    internal class Waltzes_Cross : Waltzes
    {
        public Waltzes_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._11_2;
        }
    }
}
