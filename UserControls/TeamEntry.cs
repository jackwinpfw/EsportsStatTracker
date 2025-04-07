using EsportsStatTracker.Classes;
using EsportsStatTracker.Forms;
using System;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        Game game = new Game();
        string teamName = string.Empty;
        public TeamEntry()
        {
            InitializeComponent();
        }

        public TeamEntry(string input, Game game)
        {
            InitializeComponent();
            this.game.SetTType(game.GetTType());
            teamName = input;
            SetTitle();
        }

        public string GetTeamName()
        {
            return teamName;
        }

        public Game GetGame()
        {
            return game;
        }

        public void SetTitle()
        {
            string title = game.GetStringType();
            if (teamName != string.Empty) title += " - " + teamName;
            GameTitle.Text = title;
        }

        private void DeleteTeam(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                ((SeasonEntry)(Parent.Parent.Parent)).RemoveTeam(this);
            }
        }

        private void EditTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            if (nepf.ShowPrompt(ref teamName, ref game) == DialogResult.OK)
            {
                SetTitle();
            }
        }
    }
}
