using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Tracker
{
    public partial class NavBar : UserControl
    {

        private MainApp _mainApp;


        public NavBar()
        {
            InitializeComponent();
        }
        public NavBar(MainApp _mainApp)
        {
            this._mainApp = _mainApp;
            InitializeComponent();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            _mainApp.LoadHome();
        }

        private void historyBtn_Click(object sender, EventArgs e)
        {
            _mainApp.LoadHistory();
        }
    }
}
