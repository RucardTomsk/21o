using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Dozens.Cards
{
    internal class Dozens_Diamonds : Dozens
    {
        public Dozens_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._10_1;
        }
    }
}
