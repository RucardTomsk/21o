using Soliter.Deck;
using Soliter.Deck.Aces.Cards;
using Soliter.Deck.Dozens.Cards;
using Soliter.Deck.Eights.Cards;
using Soliter.Deck.Kings.Cards;
using Soliter.Deck.Ladies.Cards;
using Soliter.Deck.Nines.Cards;
using Soliter.Deck.Sevens.Cards;
using Soliter.Deck.Sixes.Cards;
using Soliter.Deck.Waltzes.Cards;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Soliter
{

    public partial class Game : Form
    {

        const int wCard = 120;
        const int hCard = 180;
        const int pass = 10;
        string userName;

        public Game(string userName)
        {
            /*
            [DllImport("kernel32.dll", SetLastError = true)]
            [return: MarshalAs(UnmanagedType.Bool)]
            static extern bool AllocConsole();
            */

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null, panel1, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel2, new object[] { true });

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, panel3, new object[] { true });


            //AllocConsole();
            this.userName = userName;
        }

        Aces_Hearts a_h = new Aces_Hearts();
        Aces_Peaks a_p = new Aces_Peaks();
        Ace_Cross a_c = new Ace_Cross();
        Ace_Diamonds a_d = new Ace_Diamonds();
        Dozens_Cross d_c = new Dozens_Cross();
        Dozens_Diamonds d_d = new Dozens_Diamonds();
        Dozens_Hearts d_h = new Dozens_Hearts();
        Dozens_Peaks d_p = new Dozens_Peaks();
        Eights_Cross e_c = new Eights_Cross();
        Eights_Diamonds e_d = new Eights_Diamonds();
        Eights_Hearts e_h = new Eights_Hearts();
        Eights_Peaks e_p = new Eights_Peaks();
        Kings_Hearts k_h = new Kings_Hearts();
        Kings_Diamonds k_d = new Kings_Diamonds();
        Kings_Cross k_c = new Kings_Cross();
        Kings_Peaks k_p = new Kings_Peaks();
        Ladies_Cross l_c = new Ladies_Cross();
        Ladies_Diamonds l_d = new Ladies_Diamonds();
        Ladies_Hearts l_h = new Ladies_Hearts();
        Ladies_Peaks l_p = new Ladies_Peaks();
        Nines_Cross n_c = new Nines_Cross();
        Nines_Diamonds n_d = new Nines_Diamonds();
        Nines_Hearts n_h = new Nines_Hearts();
        Nines_Peaks n_p = new Nines_Peaks();
        Sevens_Cross s_c = new Sevens_Cross();
        Sevens_Diamonds s_d = new Sevens_Diamonds();
        Sevens_Hearts s_h = new Sevens_Hearts();
        Sevens_Peaks s_p = new Sevens_Peaks();
        Sixes_Cross si_c = new Sixes_Cross();
        Sixes_Diamonds si_d = new Sixes_Diamonds();
        Sixes_Hearts si_h = new Sixes_Hearts();
        Sixes_Peaks si_p = new Sixes_Peaks();
        Waltzes_Cross w_c = new Waltzes_Cross();
        Waltzes_Diamonds w_d = new Waltzes_Diamonds();
        Waltzes_Hearts w_h = new Waltzes_Hearts();
        Waltzes_Peaks w_p = new Waltzes_Peaks();


        List<Card> deck = new List<Card>();
        List<Card> userCards = new List<Card>();
        List<Card> botCards = new List<Card>();

        int userEX = 100;
        int userStav = 0;
        int userCost = 0;
        int botCost = 0;
        bool flagGame = false;
        DateTime date = new DateTime(0, 0);
        Random rnd = new Random();


        private void Game_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            labelEX2.Visible = false;
            labelEX2.Text = userStav.ToString();
            labelST.Visible = true;
            buttonPlus.Visible = true;
            buttonMinus.Visible = true;
            labelST2.Visible = true;
            buttonSTA.Visible = true;

            userCost = 0;
            botCost = 0;
            userStav = 0;
            deck.Clear();
            userCards.Clear();
            botCards.Clear();
            labelName.Text = this.userName + " " + userCost.ToString();
            labelNameBot.Text = "Машина 0";
            List<Card> cards = new List<Card>(52);
            cards.Add(a_h);
            cards.Add(a_p);
            cards.Add(a_c);
            cards.Add(a_d);
            cards.Add(d_c);
            cards.Add(d_d);
            cards.Add(d_h);
            cards.Add(d_p);
            cards.Add(e_c);
            cards.Add(e_d);
            cards.Add(e_h);
            cards.Add(e_p);
            cards.Add(k_h);
            cards.Add(k_d);
            cards.Add(k_c);
            cards.Add(k_p);
            cards.Add(l_c);
            cards.Add(l_d);
            cards.Add(l_h);
            cards.Add(l_p);
            cards.Add(n_c);
            cards.Add(n_d);
            cards.Add(n_h);
            cards.Add(n_p);
            cards.Add(s_c);
            cards.Add(s_d);
            cards.Add(s_h);
            cards.Add(s_p);
            cards.Add(si_c);
            cards.Add(si_d);
            cards.Add(si_h);
            cards.Add(si_p);
            cards.Add(w_c);
            cards.Add(w_d);
            cards.Add(w_h);
            cards.Add(w_p);



            for (int i = cards.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                (cards[j], cards[i]) = (cards[i], cards[j]);
            }

            foreach (Card card in cards)
            {
                card.Closed = true;
                deck.Add(card);
            }

        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            foreach (var card in deck)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, 0, 0);

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            int startX = 0;
            foreach (var card in botCards)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, startX, 0);
                startX = startX + 15;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            int startX = 0;
            foreach (var card in userCards)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, startX, 0);
                startX = startX + 15;
            }
        }


        private void reset_timer_Tick(object sender, EventArgs e)
        {
            if (userStav == 0)
            {
                buttonMinus.Enabled = false;
                buttonSTA.Enabled = false;
            }
            else
            {
                buttonMinus.Enabled = true;
                buttonSTA.Enabled = true;
            }

            if (userEX == 0)
            {
                buttonPlus.Enabled = false;
            }
            else
            {
                buttonPlus.Enabled = true;
            }

            labelName.Text = userName + " " + userCost.ToString();
            labelNameBot.Text = "Машина " + botCost.ToString();


            labelST2.Text = userStav.ToString();
            labelEX.Text = userEX.ToString();
            Refresh();
        }


        private void buttonExit_Click(object sender, EventArgs e)
        {
            EndGame formEndGame = new EndGame(userEX, userName, this);
            formEndGame.Show();
            this.Close();
        }



        private void buttonMinus_Click(object sender, EventArgs e)
        {
            userStav -= 10;
            userEX += 10;
            if (userStav == 0)
                buttonMinus.Enabled = false;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            userStav += 10;
            userEX -= 10;
            if (userEX == 0)
                buttonPlus.Enabled = false;
        }

        private void buttonSTA_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            labelEX2.Visible = true;
            buttonNext.Visible = true;
            buttonPass.Visible = true;
           
            buttonNext.Enabled = true;
            buttonPass.Enabled = true;
          
            labelEX2.Text = userStav.ToString();
            labelST.Visible = false;
            buttonPlus.Visible = false;
            buttonMinus.Visible = false;
            labelST2.Visible = false;
            buttonSTA.Visible = false;
            buttonExit.Visible = false;

            userCards.Add(deck[deck.Count - 1]);
            userCards[0].Closed = false;
            deck.RemoveAt(deck.Count - 1);
            userCost += (int)userCards[0].Cost;

            botCards.Add(deck[deck.Count - 1]);
            botCards[botCards.Count - 1].Closed = false;
            deck.RemoveAt(deck.Count - 1);
            botCost += (int)botCards[0].Cost;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var card = deck[deck.Count - 1];
            card.Closed = false;
            userCards.Add(card);
            deck.RemoveAt(deck.Count - 1);
            userCost += (int)card.Cost;

            if (userCost > 21)
            {
                buttonNext.Visible = false;
                buttonPass.Visible = false;
     
                labelLose.Visible = true;
                buttonRaund.Visible = true;
            }
        }

        private void buttonRaund_Click(object sender, EventArgs e)
        {
            labelLose.Visible = false;
            labelWin.Visible = false;
            buttonRaund.Visible = false;
            buttonExit.Visible = true;
            Game_Load(sender, e);
        }

        private bool shiftBot()
        {
            int a = rnd.Next(2);
            int gran = 6;
            if (a != 0)
                gran = 4;
            while (botCost + gran < 21)
            {
                botCards.Add(deck[deck.Count - 1]);
                botCards[botCards.Count - 1].Closed = false;
                deck.RemoveAt(deck.Count - 1);
                botCost += (int)botCards[botCards.Count - 1].Cost;
            }

            if (botCost > 21)
            {
                return false;
            }
            else if (botCost >= userCost)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void buttonPass_Click(object sender, EventArgs e)
        {
            if (!shiftBot())
            {
                buttonNext.Visible = false;
                buttonPass.Visible = false;
             
                labelWin.Visible = true;
                userEX += userStav * 2;
                buttonRaund.Visible = true;
            }
            else
            {
                buttonNext.Visible = false;
                buttonPass.Visible = false;
            
                labelLose.Visible = true;
                buttonRaund.Visible = true;
            }
        }
    }
}
