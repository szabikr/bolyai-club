using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public class RoomUpdaterPanel : DataUpdaterPanel
    {

        public RoomUpdaterPanel() : base()
        {
            this.actionPanel = new RoomAddPanel();
            base.initializeActionPanel();
            this.Controls.Add(this.actionPanel);
        }

        protected override void addButton_Click(object sender, EventArgs e)
        {
            base.addButton_Click(sender, e);
            base.instantiateActionPanel(new RoomAddPanel());
        }

        protected override void removeButton_Click(object sender, EventArgs e)
        {
            base.removeButton_Click(sender, e);
            base.instantiateActionPanel(new RoomRemovePanel());
        }

        protected override void modifyButton_Click(object sender, EventArgs e)
        {
            base.modifyButton_Click(sender, e);
            base.instantiateActionPanel(new RoomModifyPanel());
        }

    }
}
