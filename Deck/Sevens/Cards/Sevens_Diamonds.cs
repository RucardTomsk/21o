using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sevens.Cards
{
    internal class Sevens_Diamonds : Sevens
    {
        public Sevens_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._7_1;
        }
    }
}
