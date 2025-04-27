using EsportsStatTracker.Database_Models;
using EsportsStatTracker.UserControls;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EsportsStatTracker.Forms
{
    public partial class TeamGames : Form
    {
        private TeamEntry ParentEntry {  get; set; }
        private List<Match> Matches = new List<Match>();

        public TeamGames(TeamEntry parent)
        {
            InitializeComponent();
            ParentEntry = parent;
            Title.Text = ParentEntry.GetTitle();
            LoadGames();
        }

        public void LoadGames()
        {
            IMongoDatabase database = MainScreen.GetDatabase();

            List<PlaysIn> playsIn = database.GetCollection<PlaysIn>("plays_in").Find(Builders<PlaysIn>.Filter.Eq(p => p.TeamId, ParentEntry.GetObjectId())).ToList();

            foreach (PlaysIn play in playsIn)
            {
                Matches.Add(database.GetCollection<Match>("matches").Find(Builders<Match>.Filter.Eq(m => m.Id, play.MatchId)).First());
            }

            Matches = Matches.OrderByDescending(match => match.DatePlayed).ToList();

            foreach (Match match in Matches)
            {
                GameEntry gameEntry = new GameEntry(match, this);
                FlowPanel.Controls.Add(gameEntry);
            }
        }

        public bool MatchExists(Match ma)
        {
            foreach (Match match in Matches)
            {
                if (match.DatePlayed == ma.DatePlayed && match.OppName == ma.OppName)
                {
                    return true;
                }
            }

            return false;
        }

        private void AddMatch(Match match)
        {
            Matches.Add(match);
            Matches = Matches.OrderByDescending(m => m.DatePlayed).ToList();

            FlowPanel.Controls.Clear();
            foreach (var m in Matches)
            {
                FlowPanel.Controls.Add(new GameEntry(m, this));
            }
        }

        private void NewGame(object sender, EventArgs e)
        {
            NewGamePrompt ngp = new NewGamePrompt();

            Match m = new Match();

            if (ngp.ShowPrompt(ref m) == DialogResult.OK)
            {
                if (MatchExists(m))
                {
                    MessageBox.Show("This match already exists! Please choose a different date or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainScreen.InsertData("matches", m);

                AddMatch(m);

                GameEntry ge = new GameEntry(m, this);

                PlaysIn playsIn = new PlaysIn(ParentEntry.GetObjectId(), m.Id);
                MainScreen.InsertData("plays_in", playsIn);
            }
        }
    }
}
