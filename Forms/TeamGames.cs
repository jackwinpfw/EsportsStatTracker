using EsportsStatTracker.Database_Models;
using EsportsStatTracker.UserControls;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private bool MatchExists(Match ma)
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

            string oppName = string.Empty;
            int pfwScore = 0, oppScore = 0;
            DateTime gameDate = DateTime.Now;

            if (ngp.ShowPrompt(ref pfwScore, ref oppName, ref oppScore, ref gameDate) == DialogResult.OK)
            {
                Match match = new Match(pfwScore, oppName, oppScore, gameDate);

                if (MatchExists(match))
                {
                    MessageBox.Show("This match already exists! Please choose a different date or name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MainScreen.InsertData("matches", match);

                AddMatch(match);

                GameEntry ge = new GameEntry(match, this);

                PlaysIn playsIn = new PlaysIn(ParentEntry.GetObjectId(), match.Id);
                MainScreen.InsertData("plays_in", playsIn);
            }
        }
    }
}
