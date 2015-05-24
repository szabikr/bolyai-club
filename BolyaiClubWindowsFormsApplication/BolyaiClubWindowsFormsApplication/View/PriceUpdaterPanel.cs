using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public class PriceUpdaterPanel : DataUpdaterPanel
    {
        
        public PriceUpdaterPanel() : base()
        {
            this.actionPanel = new PriceAddPanel();
            base.initializeActionPanel();
            this.Controls.Add(this.actionPanel);
        }

        protected override void addButton_Click(object sender, EventArgs e)
        {
            base.addButton_Click(sender, e);
            base.instantiateActionPanel(new PriceAddPanel());
        }

        protected override void removeButton_Click(object sender, EventArgs e)
        {
            base.removeButton_Click(sender, e);
            base.instantiateActionPanel(new PriceRemovePanel());
        }

        protected override void modifyButton_Click(object sender, EventArgs e)
        {
            base.modifyButton_Click(sender, e);
            base.instantiateActionPanel(new PriceModifyPanel());
        }

    }
}
