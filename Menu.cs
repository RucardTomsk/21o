namespace Soliter
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.UserPaint, true);

            UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bStat_Click(object sender, EventArgs e)
        {
            Record formRec = new Record();
            formRec.Show();
            this.Hide();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame formStartGame = new StartGame();
            formStartGame.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}