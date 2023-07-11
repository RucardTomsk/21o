using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Waltzes.Cards
{
    internal class Waltzes_Hearts : Waltzes
    {
        public Waltzes_Hearts() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Hearts;
            this.Image = CardResource._11_0;
        }
    }
}
