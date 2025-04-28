using EsportsStatTracker.Database_Models;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class NewSeasonPrompt : Form
    {
        public NewSeasonPrompt()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
        }

        /// <summary>
        /// This will show a dialog box
        /// </summary>
        /// <param name="type">The type of information to be retrieved. Ex: "season" or "team"</param>
        /// <param name="value">The ref variable for the value to be entered into</param>
        public DialogResult ShowPrompt(ref string semester, ref int year)
        {
            radioFall.Checked = semester.Contains("F");
            radioSpring.Checked = !radioFall.Checked;

            yearSelector.Value = year;

            if (ShowDialog() != DialogResult.OK) return DialogResult.Cancel;

            year = (int)yearSelector.Value;
            semester = radioFall.Checked ? "Fall" : "Spring";

            if (MainScreen.SeasonExists(new Season(semester, year)))
            {
                MessageBox.Show("This season already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }

            return DialogResult.OK;
        }

        public DialogResult EditPrompt(ref Season season)
        {
            radioFall.Checked = season.Semester.Contains("F");
            radioSpring.Checked = !radioFall.Checked;

            yearSelector.Value = season.Year;

            if (ShowDialog() != DialogResult.OK) return DialogResult.Cancel;

            if (season.Year == (int)yearSelector.Value && season.Semester == (radioFall.Checked ? "Fall" : "Spring")) return DialogResult.Cancel;

            season.Year = (int)yearSelector.Value;
            season.Semester = radioFall.Checked ? "Fall" : "Spring";

            if (MainScreen.SeasonExists(season))
            {
                MessageBox.Show("This season already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }

            return DialogResult.OK;
        }
    }
}
