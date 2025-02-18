using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportsStatTracker
{
    public partial class SeasonEntry : UserControl
    {
        public SeasonEntry()
        {
            InitializeComponent();
        }

        public SeasonEntry(String name)
        {
            InitializeComponent();
            SeasonTitle.Text = name;
        }
    }
}
