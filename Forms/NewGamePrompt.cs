using EsportsStatTracker.Database_Models;
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
    public partial class NewGamePrompt : Form
    {
        public NewGamePrompt()
        {
            InitializeComponent();
        }

        public DialogResult ShowPrompt(ref Match match)
        {
            PFWScore.Value = match.PfwScore;
            OppNameBox.Text = match.OppName;
            OppScore.Value = match.OppScore;
            DatePicker.Value = match.DatePlayed;

            DialogResult res = ShowDialog();

            match.PfwScore = (int)PFWScore.Value;
            match.OppName = OppNameBox.Text;
            match.OppScore = (int)OppScore.Value;
            match.DatePlayed = DatePicker.Value;

            return res;
        }
    }
}
