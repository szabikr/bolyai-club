using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class PriceInputPanel
    {

        private void InitializeComponent()
        {
            this.roomNameLabel = new MetroFramework.Controls.MetroLabel();
            this.roomNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nonProfitLabel = new MetroFramework.Controls.MetroLabel();
            this.nonProfitToggle = new MetroFramework.Controls.MetroToggle();
            this.valueLabel = new MetroFramework.Controls.MetroLabel();
            this.valueTextBox = new MetroFramework.Controls.MetroTextBox();
            //
            // roomNameLabel
            //
            this.roomNameLabel.AutoSize = true;
            this.roomNameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.roomNameLabel.Location = new System.Drawing.Point(60, 150);
            this.roomNameLabel.Name = "roomNameLabel";
            this.roomNameLabel.Size = new System.Drawing.Size(70, 15);
            this.roomNameLabel.TabIndex = 2;
            this.roomNameLabel.Text = "Room name";
            //
            // roomNameTextBox
            //
            this.roomNameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.roomNameTextBox.Location = new System.Drawing.Point(60, 168);
            this.roomNameTextBox.MaxLength = 32767;
            this.roomNameTextBox.Name = "roomNameTextBox";
            this.roomNameTextBox.PasswordChar = '\0';
            this.roomNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.roomNameTextBox.SelectedText = "";
            this.roomNameTextBox.Size = new System.Drawing.Size(250, 30);
            this.roomNameTextBox.TabIndex = 3;
            this.roomNameTextBox.Text = "";
            this.roomNameTextBox.UseSelectable = true;
            //
            // nonProfitLabel
            //
            this.nonProfitLabel.AutoSize = true;
            this.nonProfitLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.nonProfitLabel.Location = new System.Drawing.Point(60, 225);
            this.nonProfitLabel.Name = "nonProfitLabel";
            this.nonProfitLabel.Size = new System.Drawing.Size(70, 15);
            this.nonProfitLabel.TabIndex = 2;
            this.nonProfitLabel.Text = "Non-profit";
            //
            // nonProfitToggle
            //
            this.nonProfitToggle.AutoSize = true;
            this.nonProfitToggle.Style = MetroFramework.MetroColorStyle.Brown;
            this.nonProfitToggle.Location = new System.Drawing.Point(230, 225);
            this.nonProfitToggle.Name = "nonProfitToggle";
            this.nonProfitToggle.Size = new System.Drawing.Size(80, 17);
            this.nonProfitToggle.TabIndex = 0;
            this.nonProfitToggle.Text = "";
            this.nonProfitToggle.UseSelectable = true;
            this.nonProfitToggle.UseStyleColors = true;
            //
            // valueLabel
            //
            this.valueLabel.AutoSize = true;
            this.valueLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.valueLabel.Location = new System.Drawing.Point(60, 270);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(70, 15);
            this.valueLabel.TabIndex = 6;
            this.valueLabel.Text = "Value";
            //
            // valueTextBox
            //
            this.valueTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.valueTextBox.Location = new System.Drawing.Point(60, 288);
            this.valueTextBox.MaxLength = 32767;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.PasswordChar = '\0';
            this.valueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.valueTextBox.SelectedText = "";
            this.valueTextBox.Size = new System.Drawing.Size(250, 30);
            this.valueTextBox.TabIndex = 7;
            this.valueTextBox.Text = "";
            this.valueTextBox.UseSelectable = true;
            //
            // PriceInputPanel
            //
            this.Controls.Add(this.roomNameLabel);
            this.Controls.Add(this.roomNameTextBox);
            this.Controls.Add(this.nonProfitLabel);
            this.Controls.Add(this.nonProfitToggle);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.valueTextBox);
        }

        protected MetroFramework.Controls.MetroLabel roomNameLabel;
        protected MetroFramework.Controls.MetroTextBox roomNameTextBox;
        protected MetroFramework.Controls.MetroLabel nonProfitLabel;
        protected MetroFramework.Controls.MetroToggle nonProfitToggle;
        protected MetroFramework.Controls.MetroLabel valueLabel;
        protected MetroFramework.Controls.MetroTextBox valueTextBox;

    }
}
