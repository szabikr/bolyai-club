using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class ClientInputPanel
    {

        private void InitializeComponent()
        {
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.mobileLabel = new MetroFramework.Controls.MetroLabel();
            this.mobileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.nonProfitLabel = new MetroFramework.Controls.MetroLabel();
            this.nonProfitToggle = new MetroFramework.Controls.MetroToggle();
            //
            // nameLabel
            //
            this.nameLabel.AutoSize = true;
            this.nameLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.nameLabel.Location = new System.Drawing.Point(60, 90);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(68, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            //
            // nameTextBox
            //
            this.nameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameTextBox.Location = new System.Drawing.Point(60, 108);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(250, 30);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.Text = "";
            this.nameTextBox.UseSelectable = true;
            //
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.emailLabel.Location = new System.Drawing.Point(60, 150);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(70, 15);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            //
            // emailTextBox
            //
            this.emailTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.emailTextBox.Location = new System.Drawing.Point(60, 168);
            this.emailTextBox.MaxLength = 32767;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(250, 30);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Text = "";
            this.emailTextBox.UseSelectable = true;
            //
            // mobileLabel
            //
            this.mobileLabel.AutoSize = true;
            this.mobileLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.mobileLabel.Location = new System.Drawing.Point(60, 210);
            this.mobileLabel.Name = "mobileLabel";
            this.mobileLabel.Size = new System.Drawing.Size(70, 15);
            this.mobileLabel.TabIndex = 4;
            this.mobileLabel.Text = "Mobile";
            //
            // mobileTextBox
            //
            this.mobileTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mobileTextBox.Location = new System.Drawing.Point(60, 228);
            this.mobileTextBox.MaxLength = 32767;
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.PasswordChar = '\0';
            this.mobileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mobileTextBox.SelectedText = "";
            this.mobileTextBox.Size = new System.Drawing.Size(250, 30);
            this.mobileTextBox.TabIndex = 5;
            this.mobileTextBox.Text = "";
            this.mobileTextBox.UseSelectable = true;
            //
            // nonProfitLabel
            //
            this.nonProfitLabel.AutoSize = true;
            this.nonProfitLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.nonProfitLabel.Location = new System.Drawing.Point(60, 285);
            this.nonProfitLabel.Name = "nonProfitLabel";
            this.nonProfitLabel.Size = new System.Drawing.Size(70, 15);
            this.nonProfitLabel.TabIndex = 2;
            this.nonProfitLabel.Text = "Non-profit";
            //
            // nonProfitToggle
            //
            this.nonProfitToggle.AutoSize = true;
            this.nonProfitToggle.Style = MetroFramework.MetroColorStyle.Brown;
            this.nonProfitToggle.Location = new System.Drawing.Point(230, 285);
            this.nonProfitToggle.Name = "nonProfitToggle";
            this.nonProfitToggle.Size = new System.Drawing.Size(80, 17);
            this.nonProfitToggle.TabIndex = 0;
            this.nonProfitToggle.Text = "";
            this.nonProfitToggle.UseSelectable = true;
            this.nonProfitToggle.UseStyleColors = true;
            //
            // UserInputPanel
            // 
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.nonProfitLabel);
            this.Controls.Add(this.nonProfitToggle);
        }

        protected MetroFramework.Controls.MetroLabel nameLabel;
        protected MetroFramework.Controls.MetroTextBox nameTextBox;
        protected MetroFramework.Controls.MetroLabel emailLabel;
        protected MetroFramework.Controls.MetroTextBox emailTextBox;
        protected MetroFramework.Controls.MetroLabel mobileLabel;
        protected MetroFramework.Controls.MetroTextBox mobileTextBox;
        protected MetroFramework.Controls.MetroLabel nonProfitLabel;
        protected MetroFramework.Controls.MetroToggle nonProfitToggle;

    }
}
