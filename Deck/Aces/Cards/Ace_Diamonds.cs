using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Aces.Cards
{
    internal class Ace_Diamonds: Ace
    {
        public Ace_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._1_1;
        }
    }
}
