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
        public DialogResult ShowPrompt(ref string name, ref string game)
        {
            int index = -1;
            for (int i = 0; i < GameBox.Items.Count; i++)
            {
                if (GameBox.Items[i].ToString() == game)
                { 
                    index = i;
                    break;
                }
            }

            InputBox.Text = name;

            if (index < 0) index = 0;
            GameBox.SelectedIndex = index;

            DialogResult res = ShowDialog();

            name = InputBox.Text;
            game = GameBox.Items[GameBox.SelectedIndex].ToString();
            return res;
        }
    }
}
