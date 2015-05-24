using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    class UserUpdaterPanel : DataUpdaterPanel
    {

        public UserUpdaterPanel() : base()
        {
            this.actionPanel = new UserAddPanel();
            base.initializeActionPanel();
            this.Controls.Add(this.actionPanel);
        }

        protected override void addButton_Click(object sender, EventArgs e)
        {
            base.addButton_Click(sender, e);
            base.instantiateActionPanel(new UserAddPanel());
        }

        protected override void removeButton_Click(object sender, EventArgs e)
        {
            base.removeButton_Click(sender, e);
            base.instantiateActionPanel(new UserRemovePanel());
        }

        protected override void modifyButton_Click(object sender, EventArgs e)
        {
            base.modifyButton_Click(sender, e);
            base.instantiateActionPanel(new UserModifyPanel());
        }

    }
}
