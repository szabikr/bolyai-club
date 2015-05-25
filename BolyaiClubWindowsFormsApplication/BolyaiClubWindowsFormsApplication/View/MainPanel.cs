using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class MainPanel : BasePanel
    {

        public MainPanel() : base()
        {
            InitializeCompontent();
            this.userPanel = new UserPanel();
            this.Controls.Add(this.userPanel);
            this.contentPanel = new MenuPanel();
            this.Controls.Add(this.contentPanel);
            subscribeToEvents();
        }

        void backButton_Click(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new MenuPanel());
            subscribeToEvents();
            hideBackButton();
        }

        public void OnUserSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new UserUpdaterPanel());
            showBackButton();
        }

        public void OnClientSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new ClientUpdaterPanel());
            showBackButton();
        }

        public void OnRoomSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new RoomUpdaterPanel());
            showBackButton();
        }

        public void OnPriceSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new PriceUpdaterPanel());
            showBackButton();
        }

        public void OnMakeReservationSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new MakeReservationPanel());
            showBackButton();
        }

        public void OnFinancialReportSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new FinancialReportPanel());
            showBackButton();
        }

        public void OnShowReservationsSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new ShowReservationsPanel());
            showBackButton();
        }

        public void OnUnpaidInvoicesSelected(object sender, EventArgs e)
        {
            this.activateSelectedPanel(new UnpaidInvoicesPanel());
            showBackButton();
        }

        private void activateSelectedPanel(ContentPanel panel)
        {
            this.Controls.Remove(this.contentPanel);
            this.contentPanel = panel;
            this.Controls.Add(this.contentPanel);
        }

        private void subscribeToEvents()
        {
            if (this.contentPanel == null)
            {
                return;
            }
            this.contentPanel.UserSelected += this.OnUserSelected;
            this.contentPanel.ClientSelected += this.OnClientSelected;
            this.contentPanel.RoomSelected += this.OnRoomSelected;
            this.contentPanel.PriceSelected += this.OnPriceSelected;
            this.contentPanel.MakeReservationSelected += this.OnMakeReservationSelected;
            this.contentPanel.FinancialReportSelected += this.OnFinancialReportSelected;
            this.contentPanel.ShowReservationsSelected += this.OnShowReservationsSelected;
            this.contentPanel.UnpaidInvoicesSelected += this.OnUnpaidInvoicesSelected;
        }
    }
}
