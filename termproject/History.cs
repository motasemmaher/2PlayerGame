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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;

            foreach (Game game in Program.games)
            {
                Label name = new Label();
                name.Text = game.Player.Name + " and " + game.Goalie.Name;
                name.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                name.BackColor = Color.Transparent;
                name.Dock = DockStyle.Fill;
                name.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(name);

                Label date = new Label();
                date.Text = game.Date.ToString("dd/mm/yyyy");
                date.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                date.BackColor = Color.Transparent;
                date.Dock = DockStyle.Fill;
                date.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(date);

                Label dur = new Label();
                dur.Text = game.Duration.ToString();
                dur.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                dur.BackColor = Color.Transparent;
                dur.Dock = DockStyle.Fill;
                dur.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(dur);

                Label pscore = new Label();
                pscore.Text = game.PlayerScore.ToString();
                pscore.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                pscore.Dock = DockStyle.Fill;
                pscore.TextAlign = ContentAlignment.MiddleCenter;
                pscore.BackColor = Color.Transparent;
                tableLayoutPanel1.Controls.Add(pscore);

                Label gscore = new Label();
                gscore.Text = game.GoalieScore.ToString();
                gscore.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                gscore.BackColor = Color.Transparent;
                gscore.Dock = DockStyle.Fill;
                gscore.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(gscore);
            }
            tableLayoutPanel1.Visible = true;
        }
    }
}
