using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class UnpaidInvoicesPanel
    {

        private void InitializeComponent()
        {
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Big;
            this.titleLabel.Location = new System.Drawing.Point(3, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(257, 41);
            this.titleLabel.TabIndex = 6;
            this.titleLabel.Text = "Unpaid invoices";
            //
            // UnpaidInvoicesPanel
            //
            this.Controls.Add(this.titleLabel);
        }

        protected MetroFramework.Controls.MetroLabel titleLabel;

    }
}
