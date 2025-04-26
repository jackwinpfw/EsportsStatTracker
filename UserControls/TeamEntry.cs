using EsportsStatTracker.Database_Models;
using EsportsStatTracker.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        public SeasonEntry ParentSeason { get; set; }
        Team data;

        public TeamEntry(Team data, SeasonEntry ParentSeason)
        {
            InitializeComponent();
            this.data = data;
            SetTitle();
            this.ParentSeason = ParentSeason;
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
                ObjectId id = data.Id;
                List<PlaysIn> matches;

                IMongoDatabase database = MainScreen.GetDatabase();


                matches = database.GetCollection<PlaysIn>("plays_in").Find(t => t.TeamId == id).ToList();
                foreach (var entry in matches)
                {
                    database.GetCollection<Match>("matches").DeleteMany(Builders<Match>.Filter.Eq(m => m.Id, entry.MatchId));
                }
                database.GetCollection<PlaysIn>("plays_in").DeleteMany(Builders<PlaysIn>.Filter.Eq(p => p.TeamId, id));
                database.GetCollection<PlaysOn>("plays_on").DeleteMany(Builders<PlaysOn>.Filter.Eq(p => p.TeamId, id));
                database.GetCollection<PlaysDuring>("plays_during").DeleteMany(Builders<PlaysDuring>.Filter.Eq(p => p.TeamId, id));
                database.GetCollection<Team>("teams").DeleteOne(Builders<Team>.Filter.Eq(t => t.Id, id));

                Parent.Controls.Remove(this);
            }
        }

        private void EditTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            string teamName = data.Name;
            string game = data.Game;

            if (nepf.ShowPrompt(ref teamName, ref game) == DialogResult.OK)
            {
                data.UpdateInfo(teamName, game);
                SetTitle();
            }
        }
    }
}
