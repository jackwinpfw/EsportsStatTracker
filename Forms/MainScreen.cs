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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void NewSeason(object sender, EventArgs e)
        {
            NewSeasonPrompt nepf = new NewSeasonPrompt();

            bool isFall = true;
            int year = DateTime.Now.Year;
            if (nepf.ShowPrompt(ref isFall, ref year) == DialogResult.OK)
            {
                SeasonEntry seasonEntry = new SeasonEntry(isFall, year);
                FlowPanel.Controls.Add(seasonEntry);
            }
        }
    }
}
