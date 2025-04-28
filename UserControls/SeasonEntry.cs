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
        private Season Data;
        private List<TeamEntry> teams = new List<TeamEntry>();
        private MainScreen MainForm { get; set; }

        public SeasonEntry(Season season, MainScreen mainForm)
        {
            InitializeComponent();
            Data = season;
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

        public bool TeamExists(Team t)
        {
            foreach (TeamEntry entry in teams)
            {
                if (entry.GetTeamName() == t.Name && entry.GetGame() == t.Game)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetYear()
        {
            return Data.Year;
        }

        public string GetSemester()
        {
            return Data.Semester;
        }

        private void EditSeasonClick(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();

            Season s = new Season(Data.Semester, Data.Year);

            if (nepf.EditPrompt(ref s) == DialogResult.OK)
            {
                Data.UpdateInfo(s);
                UpdateName();

                MainForm.SortSeasons();
            }
        }

        private void NewTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            Team t = new Team();

            if (nepf.ShowPrompt(ref t) == DialogResult.OK)
            {
                if (TeamExists(t))
                {
                    MessageBox.Show("This team already exists! Please choose a different game or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainScreen.InsertData("teams", t);

                TeamEntry entry = new TeamEntry(t, this);

                AddTeam(entry);

                PlaysDuring playsDuring = new PlaysDuring(t.Id, Data.Id);
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
                ObjectId id = Data.Id;

                IMongoDatabase database = MainScreen.GetDatabase();


                TeamEntry[] teamEntries = teams.ToArray();
                foreach (TeamEntry entry in teamEntries)
                {
                    entry.DeleteTeam();
                }
                
                database.GetCollection<Season>("seasons").DeleteOne(Builders<Season>.Filter.Eq(s => s.Id, id));

                MainForm.DeleteSeason(this);
                Parent.Controls.Remove(this);
            }
        }

        private void UpdateName()
        {
            SeasonTitle.Text = Data.Semester + " " + Data.Year.ToString();
        }

        public void DeleteTeam(TeamEntry deletee)
        {
            teams.Remove(deletee);
            UpdateSize();
        }

        public void SetData(Season data)
        {
            this.Data = data;
        }

        public Season GetData()
        {
            return Data;
        }
    }
}
