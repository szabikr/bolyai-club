using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class MainForm : MetroForm
    {
        private BasePanel basePanel;

        public MainForm()
        {
            InitializeComponent();

            this.basePanel = new LoginPanel();
            this.basePanel.LoggedIn += this.OnLoggedIn;
            this.Controls.Add(basePanel);
        }

        public void OnLoggedIn(object sender, EventArgs e)
        {
            this.Controls.Remove(this.basePanel);
            this.basePanel = new MainPanel();
            this.Controls.Add(this.basePanel);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
