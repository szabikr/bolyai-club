using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class ChooseFromListPanel
    {

        private void InitializeComponent()
        {
            this.dataListBox = new System.Windows.Forms.ListBox();
            //
            // dataListBox
            //
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(380, 50);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(200, 300);
            this.dataListBox.TabIndex = 2;
            //
            // ChooseFromListPanel
            //
            this.Controls.Add(this.dataListBox);
        }

        protected System.Windows.Forms.ListBox dataListBox;

    }
}
