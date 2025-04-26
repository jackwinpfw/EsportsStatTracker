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

        public DialogResult ShowPrompt(ref int pfwScore, ref string oppName, ref int oppScore, ref DateTime gameDate)
        {
            DialogResult res = ShowDialog();

            pfwScore = (int)PFWScore.Value;
            oppName = OppNameBox.Text;
            oppScore = (int)OppScore.Value;
            gameDate = DatePicker.Value;

            return res;
        }
    }
}
