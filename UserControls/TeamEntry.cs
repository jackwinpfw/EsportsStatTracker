using EsportsStatTracker.Database_Models;
using EsportsStatTracker.Forms;
using System;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        Team data;

        public TeamEntry(Team data)
        {
            InitializeComponent();
            this.data = data;
            SetTitle();
        }

        public string GetTeamName()
        {
            return data.Name;
        }

        public string GetGame()
        {
            return data.Game;
        }

        public void SetTitle()
        {
            string title = data.Game;
            if (data.Name != string.Empty) title += " - " + data.Name;

            GameTitle.Text = title;
        }

        private void DeleteTeam(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                ((SeasonEntry)(Parent.Parent.Parent)).DeleteTeam(this);
            }
        }

        private void EditTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            string teamName = data.Name;
            string game = data.Game;

            if (nepf.ShowPrompt(ref teamName, ref game) == DialogResult.OK)
            {
                SetTitle();
            }
        }
    }
}
