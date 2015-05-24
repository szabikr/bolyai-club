using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class MenuPanel
    {

        private void InitializeComponent()
        {
            this.makeReservationTile = new MetroFramework.Controls.MetroTile();
            this.getReservationsTile = new MetroFramework.Controls.MetroTile();
            this.roomsTile = new MetroFramework.Controls.MetroTile();
            this.unpaidInvoicesTile = new MetroFramework.Controls.MetroTile();
            this.financialReportTile = new MetroFramework.Controls.MetroTile();
            this.pricesTile = new MetroFramework.Controls.MetroTile();
            this.usersTile = new MetroFramework.Controls.MetroTile();
            this.clientsTile = new MetroFramework.Controls.MetroTile();
            //
            // makeReservationTile
            //
            this.makeReservationTile.ActiveControl = null;
            this.makeReservationTile.Location = new System.Drawing.Point(58, 108);
            this.makeReservationTile.Name = "makeReservationTile";
            this.makeReservationTile.Size = new System.Drawing.Size(176, 114);
            this.makeReservationTile.Style = MetroFramework.MetroColorStyle.Yellow;
            this.makeReservationTile.TabIndex = 2;
            this.makeReservationTile.Text = "Make a Reservation";
            this.makeReservationTile.UseSelectable = true;
            this.makeReservationTile.UseStyleColors = true;
            //
            // getReservationsTile
            //
            this.getReservationsTile.ActiveControl = null;
            this.getReservationsTile.Location = new System.Drawing.Point(58, 228);
            this.getReservationsTile.Name = "getReservationsTile";
            this.getReservationsTile.Size = new System.Drawing.Size(176, 114);
            this.getReservationsTile.Style = MetroFramework.MetroColorStyle.Red;
            this.getReservationsTile.TabIndex = 5;
            this.getReservationsTile.Text = "Get Reservations";
            this.getReservationsTile.UseSelectable = true;
            this.getReservationsTile.UseStyleColors = true;
            //
            // roomsTile
            //
            this.roomsTile.ActiveControl = null;
            this.roomsTile.Location = new System.Drawing.Point(717, 228);
            this.roomsTile.Name = "roomsTile";
            this.roomsTile.Size = new System.Drawing.Size(176, 114);
            this.roomsTile.Style = MetroFramework.MetroColorStyle.Orange;
            this.roomsTile.TabIndex = 3;
            this.roomsTile.Text = "Room";
            this.roomsTile.UseSelectable = true;
            this.roomsTile.UseStyleColors = true;
            this.roomsTile.Click += roomsTile_Click;
            //
            // unpaidInvoicesTile
            //
            this.unpaidInvoicesTile.ActiveControl = null;
            this.unpaidInvoicesTile.Location = new System.Drawing.Point(240, 228);
            this.unpaidInvoicesTile.Name = "unpaidInvoicesTile";
            this.unpaidInvoicesTile.Size = new System.Drawing.Size(176, 114);
            this.unpaidInvoicesTile.Style = MetroFramework.MetroColorStyle.Blue;
            this.unpaidInvoicesTile.TabIndex = 7;
            this.unpaidInvoicesTile.Text = "Unpaid Invoices";
            this.unpaidInvoicesTile.UseSelectable = true;
            //
            // financialReportTile
            //
            this.financialReportTile.ActiveControl = null;
            this.financialReportTile.Location = new System.Drawing.Point(240, 108);
            this.financialReportTile.Name = "financialReportTile";
            this.financialReportTile.Size = new System.Drawing.Size(176, 114);
            this.financialReportTile.Style = MetroFramework.MetroColorStyle.Green;
            this.financialReportTile.TabIndex = 6;
            this.financialReportTile.Text = " Financial Reports";
            this.financialReportTile.UseSelectable = true;
            this.financialReportTile.UseStyleColors = true;
            //
            // pricesTile
            //
            this.pricesTile.ActiveControl = null;
            this.pricesTile.Location = new System.Drawing.Point(535, 108);
            this.pricesTile.Name = "pricesTile";
            this.pricesTile.Size = new System.Drawing.Size(176, 114);
            this.pricesTile.Style = MetroFramework.MetroColorStyle.Lime;
            this.pricesTile.TabIndex = 10;
            this.pricesTile.Text = "Price";
            this.pricesTile.UseSelectable = true;
            this.pricesTile.UseStyleColors = true;
            this.pricesTile.Click += pricesTile_Click;
            //
            // usersTile
            //
            this.usersTile.ActiveControl = null;
            this.usersTile.Location = new System.Drawing.Point(535, 228);
            this.usersTile.Name = "usersTile";
            this.usersTile.Size = new System.Drawing.Size(176, 114);
            this.usersTile.Style = MetroFramework.MetroColorStyle.Purple;
            this.usersTile.TabIndex = 9;
            this.usersTile.Text = "User";
            this.usersTile.UseSelectable = true;
            this.usersTile.UseStyleColors = true;
            this.usersTile.Click += usersTile_Click;
            //
            // clientsTile
            //
            this.clientsTile.ActiveControl = null;
            this.clientsTile.Location = new System.Drawing.Point(717, 108);
            this.clientsTile.Name = "clientsTile";
            this.clientsTile.Size = new System.Drawing.Size(176, 114);
            this.clientsTile.Style = MetroFramework.MetroColorStyle.Teal;
            this.clientsTile.TabIndex = 8;
            this.clientsTile.Text = "Client";
            this.clientsTile.UseSelectable = true;
            this.clientsTile.UseStyleColors = true;
            this.clientsTile.Click += clientsTile_Click;
            //
            // MenuPanel
            //
            this.Controls.Add(this.makeReservationTile);
            this.Controls.Add(this.getReservationsTile);
            this.Controls.Add(this.roomsTile);
            this.Controls.Add(this.unpaidInvoicesTile);
            this.Controls.Add(this.financialReportTile);
            this.Controls.Add(this.pricesTile);
            this.Controls.Add(this.usersTile);
            this.Controls.Add(this.clientsTile);
            this.Name = "MenuPanel";
        }

        private MetroFramework.Controls.MetroTile makeReservationTile;
        private MetroFramework.Controls.MetroTile roomsTile;
        private MetroFramework.Controls.MetroTile getReservationsTile;
        private MetroFramework.Controls.MetroTile financialReportTile;
        private MetroFramework.Controls.MetroTile unpaidInvoicesTile;
        private MetroFramework.Controls.MetroTile pricesTile;
        private MetroFramework.Controls.MetroTile usersTile;
        private MetroFramework.Controls.MetroTile clientsTile;

    }
}
