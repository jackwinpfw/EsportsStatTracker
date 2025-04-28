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
        private TeamEntry ParentEntry { get; set; }
        private List<GameEntry> Matches = new List<GameEntry>();

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
                Match match = database.GetCollection<Match>("matches").Find(Builders<Match>.Filter.Eq(m => m.Id, play.MatchId)).First();
                Matches.Add(new GameEntry(match, this));
            }

            Matches = Matches.OrderByDescending(match => match.GetDate()).ToList();

            foreach (GameEntry match in Matches)
            {
                FlowPanel.Controls.Add(match);
            }
        }

        public bool MatchExists(Match ma)
        {
            foreach (GameEntry match in Matches)
            {
                if (match.GetDate() == ma.DatePlayed && match.GetOppName() == ma.OppName)
                {
                    return true;
                }
            }

            return false;
        }

        private void AddMatch(Match match)
        {
            GameEntry entry = new GameEntry(match, this);
            Matches.Add(entry);
            Matches = Matches.OrderByDescending(m => m.GetDate()).ToList();

            FlowPanel.Controls.Clear();
            foreach (GameEntry m in Matches)
            {
                FlowPanel.Controls.Add(m);
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

        public void DeleteMatch(GameEntry game)
        {
            Matches.Remove(game);
            Matches = Matches.OrderByDescending(m => m.GetDate()).ToList();
            FlowPanel.Controls.Clear();
            foreach (GameEntry m in Matches)
            {
                FlowPanel.Controls.Add(m);
            }
        }
    }
}
