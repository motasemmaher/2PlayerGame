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
    public partial class ChoosePlayers : Form
    {

        Profile goalie = new Profile();
        Profile player = new Profile();
        bool goalieIsHuman;
        bool playerIsHuman;

        public ChoosePlayers()
        {
            InitializeComponent();
        }

        private void ChoosePlayers_Load(object sender, EventArgs e)
        {
            var goalies = from Profile p in Program.profiles
                          where p.Type.ToLower() == "goalie"
                          select p;
            var players = from Profile p in Program.profiles
                          where p.Type.ToLower() == "soccer player"
                          select p;

            if (goalies.Count() > 0)
            {
                comboBox2.DataSource = goalies.ToList();
            }
            else
            {
                gh.Enabled = false;
            }
            if (players.Count() > 0)
            {
                comboBox1.DataSource = players.ToList();
            }
            else
            {
                ph.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (gh.Checked)
            {
                goalie = comboBox2.SelectedItem as Profile;
                goalieIsHuman = true;
            }
            if (ph.Checked)
            {
                player = comboBox1.SelectedItem as Profile;
                playerIsHuman = true;
            }

            new PlayForm(goalieIsHuman, playerIsHuman, goalie, player).Show();
            this.Dispose();
        }
    }
}
