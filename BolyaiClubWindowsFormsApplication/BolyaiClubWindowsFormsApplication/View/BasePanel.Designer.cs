using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class BasePanel
    {

        private void InitializeComponent()
        {
            //
            // BasePanel
            //
            //this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HorizontalScrollbarBarColor = true;
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Location = new System.Drawing.Point(20, 30);
            this.Name = "BasePanel";
            this.Size = new System.Drawing.Size(960, 550);
            this.TabIndex = 0;
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;
        }

    }
}
