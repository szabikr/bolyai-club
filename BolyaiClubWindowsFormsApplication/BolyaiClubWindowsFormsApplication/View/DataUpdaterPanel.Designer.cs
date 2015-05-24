using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class DataUpdaterPanel
    {
        private void InitializeComponent()
        {
            this.dataListBox = new System.Windows.Forms.ListBox();
            this.addButton = new MetroFramework.Controls.MetroButton();
            this.removeButton = new MetroFramework.Controls.MetroButton();
            this.modifyButton = new MetroFramework.Controls.MetroButton();
            //
            // dataListBox
            //
            this.dataListBox.FormattingEnabled = true;
            this.dataListBox.Location = new System.Drawing.Point(13, 15);
            this.dataListBox.Name = "dataListBox";
            this.dataListBox.Size = new System.Drawing.Size(201, 264);
            this.dataListBox.TabIndex = 2;
            //
            // addButton
            this.addButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.addButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.addButton.Location = new System.Drawing.Point(13, 303);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(201, 35);
            this.addButton.Style = MetroFramework.MetroColorStyle.Brown;
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseSelectable = true;
            this.addButton.UseStyleColors = true;
            this.addButton.Click += addButton_Click;
            //
            // removeBotton
            //
            this.removeButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.removeButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.removeButton.Location = new System.Drawing.Point(13, 342);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(201, 35);
            this.removeButton.Style = MetroFramework.MetroColorStyle.Brown;
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseSelectable = true;
            this.removeButton.UseStyleColors = true;
            this.removeButton.Click += removeButton_Click;
            //
            // modifyButton
            //
            this.modifyButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.modifyButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.modifyButton.Location = new System.Drawing.Point(13, 380);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(201, 35);
            this.modifyButton.Style = MetroFramework.MetroColorStyle.Brown;
            this.modifyButton.TabIndex = 5;
            this.modifyButton.Text = "Modify";
            this.modifyButton.UseSelectable = true;
            this.modifyButton.UseStyleColors = true;
            this.modifyButton.Click += modifyButton_Click;
            //
            // DataUpdaterPanel
            //
            this.Controls.Add(this.dataListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.modifyButton);
            //this.UseCustomBackColor = true;
            //this.BackColor = MetroFramework.MetroColors.Yellow;
        }

        protected void initializeActionPanel()
        {
            //
            // actionPanel
            //
            this.actionPanel.HorizontalScrollbarBarColor = true;
            this.actionPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.actionPanel.HorizontalScrollbarSize = 10;
            this.actionPanel.Location = new System.Drawing.Point(242, 15);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(709, 417);
            this.actionPanel.TabIndex = 6;
            this.actionPanel.VerticalScrollbarBarColor = true;
            this.actionPanel.VerticalScrollbarHighlightOnWheel = false;
            this.actionPanel.VerticalScrollbarSize = 10;
            //this.actionPanel.UseCustomBackColor = true;
            //this.actionPanel.BackColor = MetroFramework.MetroColors.Teal;
        }

        protected System.Windows.Forms.ListBox dataListBox;
        protected MetroFramework.Controls.MetroButton addButton;
        protected MetroFramework.Controls.MetroButton removeButton;
        protected MetroFramework.Controls.MetroButton modifyButton;

        protected ActionPanel actionPanel;

    }
}
