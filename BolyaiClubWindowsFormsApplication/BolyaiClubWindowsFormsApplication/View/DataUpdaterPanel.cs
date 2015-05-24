using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class DataUpdaterPanel : ContentPanel
    {

        public DataUpdaterPanel() : base()
        {
            InitializeComponent();
        }

        protected void instantiateActionPanel(ActionPanel panel)
        {
            this.Controls.Remove(this.actionPanel);
            this.actionPanel = panel;
            this.initializeActionPanel();
            this.Controls.Add(this.actionPanel);
        }

        protected virtual void modifyButton_Click(object sender, EventArgs e)
        {

        }

        protected virtual void removeButton_Click(object sender, EventArgs e)
        {

        }

        protected virtual void addButton_Click(object sender, EventArgs e)
        {

        }

    }
}
