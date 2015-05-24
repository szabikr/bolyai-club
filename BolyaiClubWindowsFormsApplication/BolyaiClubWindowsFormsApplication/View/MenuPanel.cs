using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class MenuPanel : ContentPanel
    {

        public MenuPanel() : base()
        {
            InitializeComponent();
        }

        void usersTile_Click(object sender, EventArgs e)
        {
            OnUserSelected();
        }

        void roomsTile_Click(object sender, EventArgs e)
        {
            OnRoomSelected();
        }

        void pricesTile_Click(object sender, EventArgs e)
        {
            OnPriceSelected();
        }

        void clientsTile_Click(object sender, EventArgs e)
        {
            OnClientSelected();
        }

    }
}
