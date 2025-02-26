using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class TeamEntry : UserControl
    {
        public TeamEntry()
        {
            InitializeComponent();
        }

        public TeamEntry(string input)
        {
            InitializeComponent();
            GameTitle.Text = input;
        }

        public string GetTitle()
        {
            return GameTitle.Text;
        }

        public void SetTitle(string input)
        {
            GameTitle.Text = input;
        }
    }
}
