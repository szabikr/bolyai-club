using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class BasePanel : MetroPanel
    {
        public event EventHandler LoggedIn;
        public event EventHandler LoggedOut;

        public BasePanel()
        {
            InitializeComponent();
        }

        protected virtual void OnLoggedIn()
        {
            if (LoggedIn != null)
            {
                LoggedIn(this, EventArgs.Empty);
            }
        }

        protected virtual void OnLoggedOut()
        {
            if (LoggedOut != null)
            {
                LoggedOut(this, EventArgs.Empty);
            }
        }

    }
}
