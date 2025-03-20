using EsportsStatTracker.ClassesEnums;
using EsportsStatTracker.Forms;
using System;
using System.ComponentModel;
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
            this.game = game;
            teamName = input;
            SetTitle();
        }

        public string GetTitle()
        {
            return GameTitle.Text;
        }

        public void SetTitle()
        {
            string title = game.GetStringType() + " - " + teamName;
            GameTitle.Text = title;
        }

        private void DeleteTeam(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                Parent.Controls.Remove(this);
            }
        }

        private void EditTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            if (nepf.ShowPrompt(ref teamName, ref game) == DialogResult.OK)
            {
                GameTitle.Text = teamName;
            }
        }
    }
}
