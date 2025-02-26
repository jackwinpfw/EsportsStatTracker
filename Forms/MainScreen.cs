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
            NewEntryPromptForm nepf = new NewEntryPromptForm();

            string input = string.Empty;
            if (nepf.ShowPrompt("season", ref input) == DialogResult.OK)
            {
                if (input == string.Empty) return;
                SeasonEntry seasonEntry = new SeasonEntry(input);
                FlowPanel.Controls.Add(seasonEntry);
            }
        }
    }
}
