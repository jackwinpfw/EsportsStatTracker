using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class MainScreen : Form
    {
        private IMongoDatabase database;
        private static List<SeasonEntry> seasons = new List<SeasonEntry>();

        public static List<SeasonEntry> GetSeasons()
        {
            return seasons;
        }

        public void AddSeason(SeasonEntry season)
        {
            if (seasons.Count == 0)
            {
                seasons.Add(season);
                FlowPanel.Controls.Clear();
                FlowPanel.Controls.Add(season);
                return;
            }

            int i = 0;
            while (i < seasons.Count)
            {
                // Current season is older than seasons[i]
                if (seasons[i].GetYear() > season.GetYear())
                {
                    if (i + 1 == seasons.Count)
                    {
                        seasons.Add(season);
                        FlowPanel.Controls.Add(season);
                        return;
                    }
                    i++;
                    continue;
                }

                // Current season is same year as seasons[i]
                else if (seasons[i].GetYear() == season.GetYear())
                {
                    // If seasons[i] is spring, insert after, else insert before
                    if (!seasons[i].GetIsFall())
                    {
                        seasons.Insert(i + 1, season);
                        break;
                    }
                    else
                    {
                        seasons.Insert(i, season);
                        break;
                    }
                }
                // Current season is newer than seasons[i]
                else
                {
                    seasons.Insert(i, season);
                    break;
                }

            }

            FlowPanel.Controls.Clear();
            foreach (var entry in seasons)
            {
                FlowPanel.Controls.Add(entry);
            }
        }

        public static bool SeasonExists(SeasonEntry season)
        {
            bool seasonExists = false;
            foreach (var entry in seasons)
            {
                if (season.GetYear() == entry.GetYear() && season.GetIsFall() == entry.GetIsFall())
                {
                    seasonExists = true;
                    break;
                }
            }
            return seasonExists;
        }

        public MainScreen()
        {
            InitializeComponent();
            ConnectDB();
        }

        public void ConnectDB()
        {
            IConfigurationRoot settings = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

            var connectionString = settings["DB_URI"];

            database = new MongoClient(connectionString).GetDatabase("esports");

        }

        private void NewSeason(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();

            bool isFall = true;
            int year = DateTime.Now.Year;
            if (nepf.ShowPrompt(ref isFall, ref year) == DialogResult.OK)
            {
                AddSeason(new SeasonEntry(isFall, year));
            }
        }
    }
}
