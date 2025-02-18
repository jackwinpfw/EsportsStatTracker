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
            NewEntryPromptForm nspf = new NewEntryPromptForm();

            string input = string.Empty;
            if (nspf.ShowPrompt("season", ref input) == DialogResult.OK)
            {
                SeasonEntry seasonEntry = new SeasonEntry(input);
                FlowPanel.Controls.Add(seasonEntry);
            }
        }
    }
}
