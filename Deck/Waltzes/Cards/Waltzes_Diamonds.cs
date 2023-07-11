using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Waltzes.Cards
{
    internal class Waltzes_Diamonds : Waltzes
    {
        public Waltzes_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._11_1;
        }
    }
}
