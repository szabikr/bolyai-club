using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class UserPanel : MetroPanel
    {
        

        public UserPanel()
        {
            InitializeComponent();
        }

        void profilePictureBox_MouseHover(object sender, EventArgs e)
        {
            //this.UseCustomBackColor = true;
            //this.BackColor = MetroFramework.MetroColors.Teal;
            
            //this.UseStyleColors = true;
            //this.Style = MetroFramework.MetroColorStyle.Teal;
            dropDown();
        }

        void profilePictureBox_MouseLeave(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(479, 61);
            this.Controls.Remove(this.signOutButton);
        }

        private void UserPanel_MouseLeave(object sender, EventArgs e)
        {
            goUp();
        }

        //void UserPanel_MouseLeave(object sender, EventArgs e)
        //{
        //    //goUp();
        //}

        

        private void signOutButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        

    }
}
