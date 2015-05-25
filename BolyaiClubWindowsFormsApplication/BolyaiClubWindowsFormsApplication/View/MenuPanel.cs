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

        private void usersTile_Click(object sender, EventArgs e)
        {
            OnUserSelected();
        }

        private void roomsTile_Click(object sender, EventArgs e)
        {
            OnRoomSelected();
        }

        private void pricesTile_Click(object sender, EventArgs e)
        {
            OnPriceSelected();
        }

        private void clientsTile_Click(object sender, EventArgs e)
        {
            OnClientSelected();
        }

        private void makeReservationTile_Click(object sender, EventArgs e)
        {
            OnMakeReservationSelected();
        }

        void showReservationsTile_Click(object sender, EventArgs e)
        {
            OnShowReservationsSelected();
        }

        void unpaidInvoicesTile_Click(object sender, EventArgs e)
        {
            OnUnpaidInvoicesSelected();
        }

        void financialReportTile_Click(object sender, EventArgs e)
        {
            OnFinancialReportSelected();
        }

    }
}
