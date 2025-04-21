using EsportsStatTracker.Database_Models;
using EsportsStatTracker.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        public MainScreen MainForm { get; set; }
        private Season data;
        private List<TeamEntry> teams = new List<TeamEntry>();

        public SeasonEntry(Season season, MainScreen mainForm)
        {
            InitializeComponent();
            data = season;
            UpdateSize();
            UpdateName();
            MainForm = mainForm;
        }

        public void AddTeam(TeamEntry te)
        {
            teams.Add(te);
            teams = teams.OrderBy(team => team.GetGame()).ThenBy(team => team.GetTeamName()).ToList();

            FlowPanel.Controls.Clear();
            foreach (var entry in teams)
            {
                FlowPanel.Controls.Add(entry);
            }

            UpdateSize();
        }

        public bool TeamExists(Team te)
        {
            foreach (var entry in teams)
            {
                if (entry.GetTeamName() == te.Name && entry.GetGame() == te.Name)
                {
                    return true;
                }
            }
            return false;
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
                data.UpdateInfo(semester, year);
                UpdateName();

                MainForm.SortSeasons();
            }
        }

        private void NewTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            string input = string.Empty;
            string game = string.Empty;
            if (nepf.ShowPrompt(ref input, ref game) == DialogResult.OK)
            {
                Team team = new Team(input, game);

                if (TeamExists(team))
                {
                    MessageBox.Show("This team already exists! Please choose a different game or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainScreen.InsertData("teams", team);

                TeamEntry entry = new TeamEntry(team, this);

                AddTeam(entry);

                PlaysDuring playsDuring = new PlaysDuring(team.Id, data.Id);
                MainScreen.InsertData("plays_during", playsDuring);
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
                    database.GetCollection<Match>("matches").DeleteMany(Builders<Match>.Filter.Eq(m => m.Id, entry.MatchId));
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
