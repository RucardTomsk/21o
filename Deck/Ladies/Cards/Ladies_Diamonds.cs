using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Ladies.Cards
{
    internal class Ladies_Diamonds : Ladies
    {
        public Ladies_Diamonds() {
            this.Color = ColorCard.Red;
            this.Suit = Suit.Diamonds;
            this.Image = CardResource._12_1;
        }
    }
}
