using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soliter
{
    public partial class EndGame : Form
    {
        DateTime date;
        string userName;
        int EX;
        Game game;
        public EndGame(int EX, string userName, Game game)
        {
            InitializeComponent();

            this.EX = EX;
            this.userName = userName;

            labelName.Text = userName + ", вы набрали " + EX.ToString() + " очков!";
            this.game = game;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter(@"record.txt", true);
            writer.WriteLine(userName + " -> " + this.EX.ToString() + ";");
            writer.Close();
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Close();
            game.Close();
        }
    }
}
