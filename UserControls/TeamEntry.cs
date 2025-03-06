using EsportsStatTracker.Forms;
using System;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        public TeamEntry()
        {
            InitializeComponent();
        }

        public TeamEntry(string input)
        {
            InitializeComponent();
            GameTitle.Text = input;
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
            NewEntryPromptForm nepf = new NewEntryPromptForm();

            string input = string.Empty;
            if (nepf.ShowPrompt("team", ref input, GameTitle.Text) == DialogResult.OK)
            {
                if (input == string.Empty) return;
                GameTitle.Text = input;
            }
        }
    }
}
