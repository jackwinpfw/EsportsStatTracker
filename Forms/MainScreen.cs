using EsportsStatTracker.Database_Models;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class MainScreen : Form
    {
        private static IMongoDatabase database;
        private static List<SeasonEntry> seasons = new List<SeasonEntry>();

        public static List<SeasonEntry> GetSeasons()
        {
            return seasons;
        }

        public static IMongoDatabase GetDatabase()
        {
            return database;
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
                    if (!seasons[i].GetSemester().Contains("F"))
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

        public static bool SeasonExists(Season season)
        {
            bool seasonExists = false;
            foreach (var entry in seasons)
            {
                if (season.Year == entry.GetYear() && season.Semester == entry.GetSemester())
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
            if (!ConnectDB()) return;
            LoadSeasons();
        }

        public bool ConnectDB()
        {
            IConfigurationRoot settings = new ConfigurationBuilder().AddJsonFile("appsettings.json", false, true).Build();

            var connectionString = settings["DB_URI"];

            database = new MongoClient(connectionString).GetDatabase("esports");

            if (database == null)
            {
                return false;
            }

            return true;
        }

        public void InsertData<T>(string collectionName, T data)
        {
            database.GetCollection<T>(collectionName).InsertOne(data);
        }

        public void LoadSeasons()
        {
            IMongoCollection<Season> collection = database.GetCollection<Season>("seasons");
            List<Season> seasons = collection.Find(Builders<Season>.Filter.Empty).ToList();
            foreach (Season season in seasons)
            {
                AddSeason(new SeasonEntry(season));
            }
        }

        private void NewSeason(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();

            string semester = "Fall";
            int year = DateTime.Now.Year;
            if (nepf.ShowPrompt(ref semester, ref year) == DialogResult.OK)
            {
                Season data = new Season(semester, year);
                InsertData("seasons", data);

                SeasonEntry entry = new SeasonEntry(data);
                AddSeason(entry);
            }
        }
    }
}
