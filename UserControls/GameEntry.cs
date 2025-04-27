using EsportsStatTracker.Database_Models;
using EsportsStatTracker.Forms;
using System;
using System.Windows.Forms;

namespace EsportsStatTracker.UserControls
{
    public partial class GameEntry : UserControl
    {
        private Match Data;
        private TeamGames Team { get; set; }

        public GameEntry(Match data, TeamGames team)
        {
            InitializeComponent();
            Data = data;
            Team = team;
            Title.Text = GetTitle();
        }

        public string GetTitle()
        {
            string title = string.Empty;

            title += Data.DatePlayed.ToShortDateString();

            if (Data.OppName != string.Empty) title += " vs " + Data.OppName;

            return title;
        }

        private void EditMatch(object sender, EventArgs e)
        {
            NewGamePrompt ngp = new NewGamePrompt();

            Match m = new Match(
                Data.PfwScore,
                Data.OppName,
                Data.OppScore,
                Data.DatePlayed
            );

            if (ngp.ShowPrompt(ref m) == DialogResult.OK)
            {
                if (Team.MatchExists(m))
                {
                    MessageBox.Show("This match already exists! Please choose a different date or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Data.UpdateInfo(m);
                Title.Text = GetTitle();
            }
        }
    }
}
