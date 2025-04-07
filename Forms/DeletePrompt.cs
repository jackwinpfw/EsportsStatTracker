using System.Windows.Forms;

namespace EsportsStatTracker.Forms
{
    public partial class DeletePrompt : Form
    {
        public DeletePrompt()
        {
            InitializeComponent();
            AcceptButton = buttonOK;
            CancelButton = buttonCancel;
        }

        public DialogResult ShowPrompt()
        {
            DialogResult res = ShowDialog();
            return res;
        }
    }
}
