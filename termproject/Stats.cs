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
    public partial class Stats : Form
    {
        public Stats()
        {
            InitializeComponent();
        }

        private void Stats_Load(object sender, EventArgs e)
        {
            label11.Text = Program.games.Count.ToString();
            label12.Text = Program.profiles.Count.ToString();

            if (Program.games.Count == 0)
                return;

            var gScores = from g in Program.games select g.GoalieScore;
            var pScores = from g in Program.games select g.PlayerScore;
            label13.Text = Math.Max(gScores.Max(), pScores.Max()).ToString();
            label14.Text = Math.Min(gScores.Min(), pScores.Min()).ToString();

            var durations = from g in Program.games select g.Duration;
            label15.Text = durations.Min().ToString();
            label16.Text = durations.Max().ToString();
            label17.Text = durations.Sum().ToString();
        }
    }
}
