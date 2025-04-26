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
        private Team Data;
        private SeasonEntry ParentSeason { get; set; }

        public TeamEntry(Team data, SeasonEntry ParentSeason)
        {
            InitializeComponent();
            this.Data = data;
            GameTitle.Text = GetTitle();
            this.ParentSeason = ParentSeason;
        }

        public ObjectId GetObjectId()
        {
            return Data.Id;
        }

        public string GetTeamName()
        {
            return Data.Name;
        }

        public string GetGame()
        {
            return Data.Game;
        }

        public string GetTitle()
        {
            string title = Data.Game;
            if (Data.Name != string.Empty) title += " - " + Data.Name;

            return title;
        }

        public void DeleteTeam()
        {
            ObjectId id = Data.Id;
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

            ParentSeason.DeleteTeam(this);
            Parent.Controls.Remove(this);
        }

        private void DeleteTeam(object sender, EventArgs e)
        {
            DeletePrompt dp = new DeletePrompt();
            if (dp.ShowPrompt() == DialogResult.OK)
            {
                DeleteTeam();
            }
        }

        private void EditTeam(object sender, EventArgs e)
        {
            NewTeamPrompt nepf = new NewTeamPrompt();

            string teamName = Data.Name;
            string game = Data.Game;

            if (nepf.ShowPrompt(ref teamName, ref game) == DialogResult.OK)
            {
                Data.UpdateInfo(teamName, game);
                GameTitle.Text = GetTitle();
            }
        }

        private void EditGames(object sender, EventArgs e)
        {
            TeamGames teamGames = new TeamGames(this);

            teamGames.ShowDialog();
        }
    }
}
