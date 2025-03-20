using EsportsStatTracker.ClassesEnums;
using EsportsStatTracker.Forms;
using System;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        Games game = Games.NA;
        public TeamEntry()
        {
            InitializeComponent();
        }

        public TeamEntry(string input, Games game)
        {
            InitializeComponent();
            GameTitle.Text = input;
            this.game = game;
        }

        public string GetTitle()
        {
            return GameTitle.Text;
        }

        public void SetTitle(string input)
        {
            GameTitle.Text = input;
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

            string input = GameTitle.Text;
            if (nepf.ShowPrompt(ref input, ref game) == DialogResult.OK)
            {
                if (input == string.Empty) return;
                GameTitle.Text = input;
            }
        }
    }
}
