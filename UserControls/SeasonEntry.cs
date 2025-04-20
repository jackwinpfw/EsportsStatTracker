using EsportsStatTracker.Classes;
using EsportsStatTracker.Database_Models;
using EsportsStatTracker.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        private Season data;
        private List<TeamEntry> teams = new List<TeamEntry>();
        public SeasonEntry()
        {
            InitializeComponent();
            UpdateSize();
            UpdateName();
            data = null;
        }

        public SeasonEntry(Season season)
        {
            InitializeComponent();
            data = season;
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
            return data.Year;
        }

        public string GetSemester()
        {
            return data.Semester;
        }

        private void EditSeasonClick(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();
            string semester = data.Semester;
            int year = data.Year;

            if (nepf.EditPrompt(ref semester, ref year) == DialogResult.OK)
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
                ObjectId id = data.Id;
                List<PlaysIn> matches;

                IMongoDatabase database = MainScreen.GetDatabase();


                matches = database.GetCollection<PlaysIn>("plays_in").Find(s => s.SeasonId == id).ToList();
                foreach (var entry in matches)
                {
                    database.GetCollection<Database_Models.Match>("matches").DeleteMany(Builders<Database_Models.Match>.Filter.Eq(m => m.Id, entry.MatchId));
                }
                database.GetCollection<PlaysIn>("matches").DeleteMany(Builders<PlaysIn>.Filter.Eq(p => p.SeasonId, id));
                database.GetCollection<PlaysDuring>("plays_during").DeleteMany(Builders<PlaysDuring>.Filter.Eq(p => p.SeasonId, id));
                database.GetCollection<Season>("seasons").DeleteOne(Builders<Season>.Filter.Eq(s => s.Id, id));

                Parent.Controls.Remove(this);
            }
        }

        private void UpdateName()
        {
            SeasonTitle.Text = data.Semester + " " + data.Year.ToString();
        }

        public void SetData(Season data)
        {
            this.data = data;
        }

        public Season GetData()
        {
            return data;
        }
    }
}
