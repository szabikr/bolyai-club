using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class UserInputPanel
    {

        private void InitializeComponent()
        {
            this.nameLabel = new MetroFramework.Controls.MetroLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.emailLabel = new MetroFramework.Controls.MetroLabel();
            this.emailTextBox = new MetroFramework.Controls.MetroTextBox();
            this.mobileLabel = new MetroFramework.Controls.MetroLabel();
            this.mobileTextBox = new MetroFramework.Controls.MetroTextBox();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.confirmPasswordLabel = new MetroFramework.Controls.MetroLabel();
            this.confirmPasswordTextBox = new MetroFramework.Controls.MetroTextBox();
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
            // passwordLabel
            //
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.passwordLabel.Location = new System.Drawing.Point(60, 270);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(70, 15);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            //
            // passwordTextBox
            //
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordTextBox.Location = new System.Drawing.Point(60, 288);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(250, 30);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.UseSelectable = true;
            //
            // confirmPasswordLabel
            //
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.FontSize = MetroFramework.MetroLabelSize.Small;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(60, 330);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(70, 15);
            this.confirmPasswordLabel.TabIndex = 8;
            this.confirmPasswordLabel.Text = "Confirm password";
            //
            // confirmPasswordTextBox
            //
            this.confirmPasswordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(60, 348);
            this.confirmPasswordTextBox.MaxLength = 32767;
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '\0';
            this.confirmPasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.confirmPasswordTextBox.SelectedText = "";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(250, 30);
            this.confirmPasswordTextBox.TabIndex = 9;
            this.confirmPasswordTextBox.Text = "";
            this.confirmPasswordTextBox.UseSelectable = true;
            //
            // UserInputPanel
            // 
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mobileLabel);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
        }

        protected MetroFramework.Controls.MetroLabel nameLabel;
        protected MetroFramework.Controls.MetroTextBox nameTextBox;
        protected MetroFramework.Controls.MetroLabel emailLabel;
        protected MetroFramework.Controls.MetroTextBox emailTextBox;
        protected MetroFramework.Controls.MetroLabel mobileLabel;
        protected MetroFramework.Controls.MetroTextBox mobileTextBox;
        protected MetroFramework.Controls.MetroLabel passwordLabel;
        protected MetroFramework.Controls.MetroTextBox passwordTextBox;
        protected MetroFramework.Controls.MetroLabel confirmPasswordLabel;
        protected MetroFramework.Controls.MetroTextBox confirmPasswordTextBox;
        

    }
}
