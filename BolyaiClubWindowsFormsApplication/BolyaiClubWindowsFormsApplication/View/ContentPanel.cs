using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ContentPanel : MetroPanel
    {
        public event EventHandler UserSelected;
        public event EventHandler ClientSelected;
        public event EventHandler RoomSelected;
        public event EventHandler PriceSelected;
        public event EventHandler MakeReservationSelected;
        public event EventHandler FinancialReportSelected;
        public event EventHandler ShowReservationsSelected;
        public event EventHandler UnpaidInvoicesSelected;

        public ContentPanel()
        {
            InitializeComponent();
        }

        protected void OnUserSelected()
        {
            if (UserSelected != null)
            {
                UserSelected(this, EventArgs.Empty);
            }
        }

        protected void OnClientSelected()
        {
            if (ClientSelected != null)
            {
                ClientSelected(this, EventArgs.Empty);
            }
        }

        protected void OnRoomSelected()
        {
            if (RoomSelected != null)
            {
                RoomSelected(this, EventArgs.Empty);
            }
        }

        protected void OnPriceSelected()
        {
            if (PriceSelected != null)
            {
                PriceSelected(this, EventArgs.Empty);
            }
        }

        protected void OnMakeReservationSelected()
        {
            if (MakeReservationSelected != null)
            {
                MakeReservationSelected(this, EventArgs.Empty);
            }
        }

        protected void OnFinancialReportSelected()
        {
            if (FinancialReportSelected != null)
            {
                FinancialReportSelected(this, EventArgs.Empty);
            }
        }

        protected void OnShowReservationsSelected()
        {
            if (ShowReservationsSelected != null)
            {
                ShowReservationsSelected(this, EventArgs.Empty);
            }
        }

        protected void OnUnpaidInvoicesSelected()
        {
            if (UnpaidInvoicesSelected != null)
            {
                UnpaidInvoicesSelected(this, EventArgs.Empty);
            }
        }

    }
}
