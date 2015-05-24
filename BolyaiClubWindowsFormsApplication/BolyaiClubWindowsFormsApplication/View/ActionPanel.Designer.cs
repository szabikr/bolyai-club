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
            this.warningLabel = new MetroFramework.Controls.MetroLabel();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Big;
            this.titleLabel.Location = new System.Drawing.Point(15, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(171, 41);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title";
            //
            // actionButton
            //
            this.actionButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.UserPicturePlaceholder;
            this.actionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.actionButton.Location = new System.Drawing.Point(377, 39);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(300, 300);
            this.actionButton.UseSelectable = true;
            this.actionButton.Click += actionButton_Click;
            //
            // warningLabel
            //
            this.warningLabel.AutoSize = true;
            this.warningLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.warningLabel.Location = new System.Drawing.Point(60, 400);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(171, 41);
            this.warningLabel.TabIndex = 2;
            this.warningLabel.Text = "Warning";
            this.warningLabel.UseStyleColors = true;
            this.warningLabel.Style = MetroFramework.MetroColorStyle.Red;
            //
            // ActionPanel
            //
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.actionButton);
            this.Controls.Add(this.warningLabel);
        }

        protected MetroFramework.Controls.MetroLabel titleLabel;
        protected MetroFramework.Controls.MetroButton actionButton;
        protected MetroFramework.Controls.MetroLabel warningLabel;

    }
}
