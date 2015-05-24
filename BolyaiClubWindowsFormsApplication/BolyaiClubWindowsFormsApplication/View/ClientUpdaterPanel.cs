using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public class ClientUpdaterPanel : DataUpdaterPanel
    {

        public ClientUpdaterPanel() : base()
        {
            this.actionPanel = new ClientAddPanel();
            base.initializeActionPanel();
            this.Controls.Add(this.actionPanel);
        }

        protected override void addButton_Click(object sender, EventArgs e)
        {
            base.addButton_Click(sender, e);
            base.instantiateActionPanel(new ClientAddPanel());
        }

        protected override void removeButton_Click(object sender, EventArgs e)
        {
            base.removeButton_Click(sender, e);
            base.instantiateActionPanel(new ClientRemovePanel());
        }

        protected override void modifyButton_Click(object sender, EventArgs e)
        {
            base.modifyButton_Click(sender, e);
            base.instantiateActionPanel(new ClientModifyPanel());
        }

    }
}
