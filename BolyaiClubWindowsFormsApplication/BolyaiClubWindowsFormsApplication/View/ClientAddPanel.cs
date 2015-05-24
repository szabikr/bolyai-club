using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ClientAddPanel : ClientInputPanel
    {

        public ClientAddPanel() : base()
        {
            InitializeComponent();
        }

        protected override void actionButton_Click(object sender, EventArgs e)
        {
            base.actionButton_Click(sender, e);
            if (!IsValidData())
            {
                return;
            }
        }

    }
}
