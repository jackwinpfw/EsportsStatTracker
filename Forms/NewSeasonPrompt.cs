using System;
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
        public DialogResult ShowPrompt(ref bool isFall, ref int year)
        {
            radioFall.Checked = (bool)isFall;
            radioSpring.Checked = !(bool)isFall;

            yearSelector.Value = year;

            DialogResult res = ShowDialog();

            year = (int)yearSelector.Value;
            isFall = radioFall.Checked;

            return res;
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
