using EsportsStatTracker.Classes;
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
        public DialogResult ShowPrompt(ref string name, ref Game game)
        {
            InputBox.Text = name;
            comboBox1.SelectedIndex = (int)game.GetTType() - 1;
            if (comboBox1.SelectedIndex < 0) comboBox1.SelectedIndex = 0;

            DialogResult res = ShowDialog();

            name = InputBox.Text;
            game.SetIntType(comboBox1.SelectedIndex + 1);
            return res;
        }
    }
}
