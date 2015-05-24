using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class LoginPanel : BasePanel
    {

        public LoginPanel() : base()
        {
            InitializeComponent();
        }

        void proceedButton_Click(object sender, EventArgs e)
        {
            OnLoggedIn();
        }

        
    }
}
