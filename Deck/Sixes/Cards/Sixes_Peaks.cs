using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sixes.Cards
{
    internal class Sixes_Peaks : Sixes
    {
        public Sixes_Peaks() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Peaks;
            this.Image = CardResource._6_3;
        }
    }
}
