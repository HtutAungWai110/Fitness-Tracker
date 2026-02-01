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
    public partial class MainApp : Form
    {

        private int userId;
        private string userName;

        private Home _home;
        private History _history;
        private NavBar _navBar;

        public MainApp()
        {
            InitializeComponent();
        }

        public MainApp(int userId, string userName)
        {
            this.userId = userId;
            this.userName = userName;
            this._home = new Home(this.userId, this.userName);
            this._history = new History(this.userId);
            this._navBar = new NavBar(this);
            InitializeComponent();
        }

        public void LoadPage(UserControl page)
        {
            // Clear existing controls and load the new page
            this.Controls.Clear();
            page.Dock = DockStyle.Fill;
            this.Controls.Add(page);
            this.Controls.Add(_navBar);
            this._navBar.Dock = DockStyle.Bottom;
            
        }

        public void LoadHome()
        {
            // Load Home page
            LoadPage(this._home);
            _home.LoadInfo();
        }

        public void LoadHistory()
        {
            //Load History page
            LoadPage(this._history);
            _history.reload();
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            LoadPage(this._home);
        }

        private void MainApp_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.ExitThread();
        }
    }
}
