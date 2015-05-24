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

    }
}
