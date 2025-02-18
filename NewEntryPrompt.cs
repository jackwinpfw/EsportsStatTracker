using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class NewEntryPromptForm : Form
    {
        public NewEntryPromptForm()
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
        public DialogResult ShowPrompt(string type, ref string value)
        {
            PromptLabel.Text += type + ":";
            DialogResult res = ShowDialog();

            value = InputBox.Text;
            return res;
        }
    }
}
