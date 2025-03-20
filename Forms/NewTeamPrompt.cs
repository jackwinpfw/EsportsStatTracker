using EsportsStatTracker.ClassesEnums;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class NewTeamPrompt : Form
    {
        public NewTeamPrompt()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
        }

        /// <summary>
        /// This will show a dialog box
        /// </summary>
        /// <param name="type">The type of information to be retrieved. Ex: "season" or "team"</param>
        /// <param name="name">The ref variable for the value to be entered into</param>
        public DialogResult ShowPrompt(ref string name, ref Games game)
        {
            InputBox.Text = name;
            comboBox1.SelectedIndex = (int)game;

            DialogResult res = ShowDialog();

            name = InputBox.Text;
            return res;
        }
    }
}
