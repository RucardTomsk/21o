using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soliter.Deck.Sevens.Cards
{
    internal class Sevens_Peaks : Sevens
    {
        public Sevens_Peaks() {
            this.Color = ColorCard.Black;
            this.Suit = Suit.Peaks;
            this.Image = CardResource._7_3;
        }
    }
}
