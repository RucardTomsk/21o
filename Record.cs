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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader(@"record.txt"))
            {
                string text = reader.ReadToEnd();
                text = text.Replace(",", "->").Replace(";", "\n");
                textBox1.Text = text;
                reader.Close();
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Close();
        }
    }
}
