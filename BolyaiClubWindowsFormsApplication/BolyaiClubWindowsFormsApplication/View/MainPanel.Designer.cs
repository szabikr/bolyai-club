using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class MainPanel
    {

        private void InitializeCompontent()
        {
            this.titleLabel = new MetroFramework.Controls.MetroLabel();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Huge;
            this.titleLabel.Location = new System.Drawing.Point(49, 7);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(208, 54);
            this.titleLabel.TabIndex = 11;
            this.titleLabel.Text = "Bolyai Club";
            //
            // userPanel
            //
            //this.userPanel.ResumeLayout(false);
            //this.userPanel.PerformLayout();
            //
            // contentPanel
            //
            //this.contentPanel.ResumeLayout(false);
            //
            // MainPanel
            //
            this.Controls.Add(this.titleLabel);
            this.Name = "MainPanel";
        }

        private void showBackButton()
        {
            if (this.backButton == null)
            {
                this.backButton = new MetroFramework.Controls.MetroButton();
                this.InitializeBackButton();
            }
            this.Controls.Add(this.backButton);
        }

        private void hideBackButton()
        {
            this.Controls.Remove(this.backButton);
        }

        private void InitializeBackButton()
        {
            this.backButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.BackButton;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(0, 10);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.UseSelectable = true;
            this.backButton.Click += backButton_Click;
        }

        private MetroFramework.Controls.MetroLabel titleLabel;
        private UserPanel userPanel;
        private ContentPanel contentPanel;
        private MetroFramework.Controls.MetroButton backButton;

    }
}
