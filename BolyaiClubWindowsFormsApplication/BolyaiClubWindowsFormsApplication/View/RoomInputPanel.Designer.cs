using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class RoomInputPanel
    {

        private void InitializeComponent()
        {
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.capacityLabel = new MetroFramework.Controls.MetroLabel();
            this.capacityTextBox = new MetroFramework.Controls.MetroTextBox();
            //
            // nameLabel
            //
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.nameLabel.Location = new System.Drawing.Point(60, 150);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(70, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name";
            //
            // nameTextBox
            //
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameTextBox.Location = new System.Drawing.Point(60, 168);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(250, 30);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "";
            this.nameTextBox.UseSelectable = true;
            //
            // capacityLabel
            //
            this.capacityLabel.AutoSize = true;
            this.capacityLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.capacityLabel.Location = new System.Drawing.Point(60, 210);
            this.capacityLabel.Name = "capacityLabel";
            this.capacityLabel.Size = new System.Drawing.Size(70, 15);
            this.capacityLabel.TabIndex = 4;
            this.capacityLabel.Text = "Capacity";
            //
            // capacityTextBox
            //
            this.capacityTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.capacityTextBox.Location = new System.Drawing.Point(60, 228);
            this.capacityTextBox.MaxLength = 32767;
            this.capacityTextBox.Name = "capacityTextBox";
            this.capacityTextBox.PasswordChar = '\0';
            this.capacityTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.capacityTextBox.SelectedText = "";
            this.capacityTextBox.Size = new System.Drawing.Size(250, 30);
            this.capacityTextBox.TabIndex = 5;
            this.capacityTextBox.Text = "";
            this.capacityTextBox.UseSelectable = true;
            //
            // RoomInputPanel
            //
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.capacityLabel);
            this.Controls.Add(this.capacityTextBox);
        }

        protected MetroFramework.Controls.MetroLabel nameLabel;
        protected MetroFramework.Controls.MetroTextBox nameTextBox;
        protected MetroFramework.Controls.MetroLabel capacityLabel;
        protected MetroFramework.Controls.MetroTextBox capacityTextBox; 

    }
}
