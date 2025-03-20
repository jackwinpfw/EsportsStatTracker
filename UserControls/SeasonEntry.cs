using EsportsStatTracker.ClassesEnums;
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

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        bool isFall = true;
        int year;
        int teamCount = 0;
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
                FlowPanel.Controls.Add(teamEntry);
                teamCount++;
                UpdateSize();
            }
        }

        private void UpdateSize()
        {
            Height = 200 + (teamCount * 75);
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
            string name = string.Empty;
            if (isFall) name += "Fall ";
            else name += "Spring ";
            name += year.ToString();

            SeasonTitle.Text = name;
        }
    }
}
