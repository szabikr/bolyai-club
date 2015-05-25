using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class ChooseDataPanel
    {

        private void InitializeComponent()
        {
            this.chooseClientLabel = new MetroFramework.Controls.MetroLabel();
            this.chooseRoomLabel = new MetroFramework.Controls.MetroLabel();
            this.chooseTimeLabel = new MetroFramework.Controls.MetroLabel();
            this.stageProgressBar = new MetroFramework.Controls.MetroProgressBar();
            //
            // chooseClientLabel
            //
            this.chooseClientLabel.AutoSize = true;
            this.chooseClientLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.chooseClientLabel.Location = new System.Drawing.Point(325, 17);
            this.chooseClientLabel.Name = "chooseClientLabel";
            this.chooseClientLabel.Size = new System.Drawing.Size(73, 15);
            this.chooseClientLabel.TabIndex = 7;
            this.chooseClientLabel.Text = "Choose client";
            this.chooseClientLabel.UseStyleColors = true;
            //
            // chooseRoomLabel
            //
            this.chooseRoomLabel.AutoSize = true;
            this.chooseRoomLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.chooseRoomLabel.Location = new System.Drawing.Point(441, 17);
            this.chooseRoomLabel.Name = "chooseRoomLabel";
            this.chooseRoomLabel.Size = new System.Drawing.Size(76, 15);
            this.chooseRoomLabel.TabIndex = 8;
            this.chooseRoomLabel.Text = "Choose room";
            this.chooseRoomLabel.UseStyleColors = true;
            //
            // chooseDateLabel
            //
            this.chooseTimeLabel.AutoSize = true;
            this.chooseTimeLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.chooseTimeLabel.Location = new System.Drawing.Point(552, 17);
            this.chooseTimeLabel.Name = "chooseDateLabel";
            this.chooseTimeLabel.Size = new System.Drawing.Size(71, 15);
            this.chooseTimeLabel.TabIndex = 9;
            this.chooseTimeLabel.Text = "Choose date";
            this.chooseTimeLabel.UseStyleColors = true;
            //
            // stageProgressBar
            //
            this.stageProgressBar.Location = new System.Drawing.Point(311, 3);
            this.stageProgressBar.Name = "stageProgressBar";
            this.stageProgressBar.Size = new System.Drawing.Size(326, 11);
            this.stageProgressBar.TabIndex = 5;
            this.stageProgressBar.Value = 0;
            this.stageProgressBar.UseStyleColors = true;
            this.stageProgressBar.Style = MetroFramework.MetroColorStyle.Brown;
            //
            // ChooseDataPanel
            //
            this.Controls.Add(this.stageProgressBar);
            this.HorizontalScrollbarBarColor = true;
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Name = "chooseDataPanel";
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;
            //this.UseCustomBackColor = true;
            //this.BackColor = MetroFramework.MetroColors.Teal;
        }

        protected void HighlightChooseClientLabel()
        {
            this.chooseClientLabel.Style = MetroFramework.MetroColorStyle.Brown;
            this.stageProgressBar.Value = 33;
        }

        protected void HighlightChooseRoomLabel()
        {
            this.chooseRoomLabel.Style = MetroFramework.MetroColorStyle.Brown;
            this.stageProgressBar.Value = 66;
        }

        protected void HighlighChooseTimeLabel()
        {
            this.chooseTimeLabel.Style = MetroFramework.MetroColorStyle.Brown;
            this.stageProgressBar.Value = 100;
        }

        protected void InitializeBackButton()
        {
            this.backButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.PrevButton;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Location = new System.Drawing.Point(50, 350);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.UseSelectable = true;
            this.backButton.Click += backButton_Click;
        }

        protected void InitializeNextButton()
        {
            this.nextButton.BackgroundImage = global::BolyaiClubWindowsFormsApplication.Properties.Resources.NextButton;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Location = new System.Drawing.Point(848, 350);
            this.nextButton.Name = "backButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.UseSelectable = true;
            this.nextButton.Click += nextButton_Click;
        }

        protected MetroFramework.Controls.MetroLabel chooseClientLabel;
        protected MetroFramework.Controls.MetroLabel chooseRoomLabel;
        protected MetroFramework.Controls.MetroLabel chooseTimeLabel;
        protected MetroFramework.Controls.MetroProgressBar stageProgressBar;

        protected MetroFramework.Controls.MetroButton nextButton;
        protected MetroFramework.Controls.MetroButton backButton;

    }
}
