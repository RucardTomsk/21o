
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sevens.Cards
{
    internal class Sevens_Cross : Sevens
    {
        public Sevens_Cross() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Cross;
            this.Image = CardResource._7_2;
        }
    }
}
