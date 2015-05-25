using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class UserModifyPanel
    {

        private void InitializeCompontent()
        {
            this.titleLabel.Text = "User - modify";
            this.actionButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.UserEditButton;
        }

    }
}
