using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class ActionPanel
    {
        private void InitializeComponent()
        {
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            this.actionButton = new MetroFramework.Controls.MetroButton();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Big;
            this.titleLabel.Location = new System.Drawing.Point(15, 12);
            this.titleLabel.Name = "metroLabel1";
            this.titleLabel.Size = new System.Drawing.Size(171, 41);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "metroLabel1";
            //
            // actionButton
            //
            this.actionButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.UserPicturePlaceholder;
            this.actionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actionButton.Location = new System.Drawing.Point(377, 39);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(300, 300);
            this.actionButton.UseSelectable = true;
            //
            // ActionPanel
            //
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.actionButton);
        }

        protected MetroFramework.Controls.MetroLabel titleLabel;
        protected System.Windows.Forms.PictureBox actionPictureBox;
        protected MetroFramework.Controls.MetroButton actionButton;

    }
}
