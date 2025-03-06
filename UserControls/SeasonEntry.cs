using EsportsStatTracker.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        int teamCount = 0;
        public SeasonEntry()
        {
            InitializeComponent();
            UpdateSize();
        }

        public SeasonEntry(String name)
        {
            InitializeComponent();
            SeasonTitle.Text = name;
            UpdateSize();
        }

        private void EditSeasonClick(object sender, EventArgs e)
        {
            NewEntryPromptForm nepf = new NewEntryPromptForm();

            string input = string.Empty;
            if (nepf.ShowPrompt("season", ref input, SeasonTitle.Text) == DialogResult.OK)
            {
                if (input == string.Empty) return;
                SeasonTitle.Text = input;
            }
        }

        private void NewTeam(object sender, EventArgs e)
        {
            NewEntryPromptForm nepf = new NewEntryPromptForm();

            string input = string.Empty;
            if (nepf.ShowPrompt("team", ref input) == DialogResult.OK)
            {
                if (input == string.Empty) return;
                TeamEntry teamEntry = new TeamEntry(input);
                FlowPanel.Controls.Add(teamEntry);
                teamCount++;
                UpdateSize();
            }
        }

        private void UpdateSize()
        {
            Height = 200;
            Height += teamCount * 75;
        }

        private void DeleteSeason(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                Parent.Controls.Remove(this);
            }
        }
    }
}
