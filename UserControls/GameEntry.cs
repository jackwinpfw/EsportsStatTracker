using EsportsStatTracker.Database_Models;
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

namespace EsportsStatTracker.UserControls
{
    public partial class GameEntry : UserControl
    {
        private Match Data;
        private TeamGames Team { get; set; }

        public GameEntry(Match data, TeamGames team)
        {
            InitializeComponent();
            Data = data;
            Team = team;
            Title.Text = GetTitle();
        }

        public string GetTitle()
        {
            string title = string.Empty;

            title += Data.DatePlayed.ToShortDateString();

            if (Data.OppName != string.Empty) title += " vs " + Data.OppName;

            return title;
        }
    }
}
