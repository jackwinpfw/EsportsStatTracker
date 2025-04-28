using EsportsStatTracker.Database_Models;
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
        public DialogResult ShowPrompt(ref Team t)
        {
            int index = -1;
            for (int i = 0; i < GameBox.Items.Count; i++)
            {
                if (GameBox.Items[i].ToString() == t.Game)
                { 
                    index = i;
                    break;
                }
            }

            InputBox.Text = t.Name;

            if (index < 0) index = 0;
            GameBox.SelectedIndex = index;

            DialogResult res = ShowDialog();

            t.Name = InputBox.Text;
            t.Game = GameBox.Items[GameBox.SelectedIndex].ToString();
            return res;
        }
    }
}
