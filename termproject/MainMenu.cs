using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace termproject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new CreateProfile().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Stats().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new History().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new CurrentProfiles().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ChoosePlayers().Show();
        }
    }
}
