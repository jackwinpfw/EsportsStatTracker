using EsportsStatTracker.Classes;
using EsportsStatTracker.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        private List<TeamEntry> teams = new List<TeamEntry>();
        bool isFall = true;
        int year;
        public SeasonEntry()
        {
            InitializeComponent();
            UpdateSize();
            UpdateName();
        }

        public SeasonEntry(bool isFall, int year)
        {
            InitializeComponent();
            this.isFall = isFall;
            this.year = year;
            UpdateSize();
            UpdateName();
        }

        private void AddTeam(TeamEntry te)
        {
            teams.Add(te);
            teams = teams.OrderBy(team => team.GetGame().GetTType()).ThenBy(team => team.GetTeamName()).ToList();

            FlowPanel.Controls.Clear();
            foreach (var entry in teams)
            {
                FlowPanel.Controls.Add(entry);
            }
        }

        public bool TeamExists(TeamEntry te)
        {
            bool exists = false;
            foreach (var entry in teams)
            {
                if (entry.GetTeamName() == te.GetTeamName() && entry.GetGame().GetTType() == te.GetGame().GetTType())
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }

        public void RemoveTeam(TeamEntry te)
        {
            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].GetTeamName() == te.GetTeamName() && teams[i].GetGame().GetTType() == te.GetGame().GetTType())
                    teams.RemoveAt(i);
            }

            UpdateSize();
            FlowPanel.Controls.Clear();
            foreach (var entry in teams)
            {
                FlowPanel.Controls.Add(entry);
            }
        }

        public int GetYear()
        {
            return year;
        }

        public bool GetIsFall()
        {
            return isFall;
        }

        private void EditSeasonClick(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();

            if (nepf.ShowPrompt(ref isFall, ref year) == DialogResult.OK)
            {
                UpdateName();
            }
        }

        private void NewTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            string input = string.Empty;
            Game game = new Game();
            if (nepf.ShowPrompt(ref input, ref game) == DialogResult.OK)
            {
                TeamEntry teamEntry = new TeamEntry(input, game);

                if (TeamExists(teamEntry))
                {
                    MessageBox.Show("This team already exists! Please choose a different game or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                AddTeam(teamEntry);
                UpdateSize();
            }
        }

        private void UpdateSize()
        {
            Height = 200 + (teams.Count * 75);
        }

        private void DeleteSeason(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                Parent.Controls.Remove(this);
            }
        }

        private void UpdateName()
        {
            string name = "Spring ";
            if (isFall) name = "Fall ";
            name += year.ToString();

            SeasonTitle.Text = name;
        }
    }
}
