using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class UserPanel
    {

        private void InitializeComponent()
        {
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.firstNameLabel = new MetroFramework.Controls.MetroLabel();
            this.lastNameLabel = new MetroFramework.Controls.MetroLabel();
            //
            // lastNameLabel
            //
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lastNameLabel.Location = new System.Drawing.Point(305, 3);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(92, 25);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // firstNameLabel
            //
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(324, 28);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(73, 19);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            //
            // profilePictureBox
            //
            this.profilePictureBox.Image = global::BolyaiClubWindowsFormsApplication.Properties.Resources.UserPicturePlaceholder;
            this.profilePictureBox.Location = new System.Drawing.Point(418, 3);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(58, 55);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.MouseHover += profilePictureBox_MouseHover;
            //this.profilePictureBox.MouseLeave += profilePictureBox_MouseLeave;
            //this.profilePictureBox.Click += profilePictureBox_Click;
            //this.MouseLeave += UserPanel_MouseLeave;
            //
            // UserPanel
            //
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.lastNameLabel);
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Location = new System.Drawing.Point(424, 3);
            this.Name = "UserPanel";
            this.Size = new System.Drawing.Size(479, 61);
            this.TabIndex = 12;
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;
            this.MouseLeave += UserPanel_MouseLeave;
        }

        void dropDown()
        {
            this.Size = new System.Drawing.Size(479, 110);
            if (this.signOutButton == null)
            {
                this.signOutButton = new MetroFramework.Controls.MetroButton();
                this.initializeSignOutButton();
            }
            this.Controls.Add(this.signOutButton);
        }

        private void goUp()
        {
            this.Size = new System.Drawing.Size(479, 61);
            this.Controls.Remove(this.signOutButton);
        }

        private void initializeSignOutButton()
        {
            //
            // signOutButton
            //
            this.signOutButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.signOutButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.signOutButton.Location = new System.Drawing.Point(320, 75);
            this.signOutButton.Name = "signOutButton";
            this.signOutButton.Size = new System.Drawing.Size(150, 35);
            this.signOutButton.Style = MetroFramework.MetroColorStyle.Brown;
            this.signOutButton.TabIndex = 9;
            this.signOutButton.Text = "Sign Out";
            this.signOutButton.UseSelectable = true;
            this.signOutButton.UseStyleColors = true;
            this.signOutButton.Click += new System.EventHandler(this.signOutButton_Click);
        }

        private System.Windows.Forms.PictureBox profilePictureBox;
        private MetroFramework.Controls.MetroLabel firstNameLabel;
        private MetroFramework.Controls.MetroLabel lastNameLabel;
        private MetroFramework.Controls.MetroButton signOutButton;

    }
}
