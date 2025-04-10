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

            ShowDialog();

            year = (int)yearSelector.Value;
            semester = radioFall.Checked ? "Fall" : "Spring";

            if (MainScreen.SeasonExists(new SeasonEntry(semester, year)))
            {
                MessageBox.Show("This season already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Cancel;
            }

            return DialogResult.OK;
        }

        public DialogResult ShowPrompt(ref bool? isFall, string pretext)
        {
            if (isFall != null)
            {
                radioFall.Checked = (bool)isFall;
                radioSpring.Checked = !(bool)isFall;
            }

            // set radios
            DialogResult res = ShowDialog();

            isFall = true;
            return res;
        }
    }
}
