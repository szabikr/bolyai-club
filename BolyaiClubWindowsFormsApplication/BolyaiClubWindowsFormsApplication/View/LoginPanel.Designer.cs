using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

using MetroFramework.Controls;
using MetroFramework;

namespace BolyaiClubWindowsFormsApplication.View
{
    partial class LoginPanel
    {
        private void InitializeComponent()
        {
            //
            // Instansiation
            //
            this.titleLabel = new MetroLabel();
            this.usernameLabel = new MetroLabel();
            this.passwordLabel = new MetroLabel();
            this.usernameTextBox = new MetroTextBox();
            this.passwordTextBox = new MetroTextBox();
            this.proceedButton = new MetroButton();
            //
            // titleLabel
            //
            this.titleLabel.AutoSize = true;
            this.titleLabel.FontSize = MetroFramework.MetroLabelSize.Huge;
            this.titleLabel.Location = new System.Drawing.Point(79, 66);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(114, 54);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Login";
            //
            // usernameLabel
            //
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(139, 167);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 5;
            this.usernameLabel.Text = "Username";
            //
            // passwordLabel
            //
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(139, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 19);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password";
            //
            // usernameTextBox
            //
            this.usernameTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.usernameTextBox.Location = new System.Drawing.Point(139, 189);
            this.usernameTextBox.MaxLength = 32767;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.PasswordChar = '\0';
            this.usernameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.usernameTextBox.SelectedText = "";
            this.usernameTextBox.Size = new System.Drawing.Size(300, 35);
            this.usernameTextBox.TabIndex = 7;
            this.usernameTextBox.Text = "";
            this.usernameTextBox.UseSelectable = true;
            //
            // passwordTextBox
            //
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordTextBox.Location = new System.Drawing.Point(139, 268);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(300, 35);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.Text = "";
            this.passwordTextBox.UseSelectable = true;
            //
            // proceedButton
            //
            this.proceedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.proceedButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.proceedButton.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.proceedButton.ForeColor = MetroColors.White;
            //this.proceedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.proceedButton.Location = new System.Drawing.Point(139, 349);
            this.proceedButton.Name = "proceedButton";
            this.proceedButton.Size = new System.Drawing.Size(300, 35);
            this.proceedButton.Style = MetroFramework.MetroColorStyle.Black;
            this.proceedButton.TabIndex = 9;
            this.proceedButton.Text = "Proceed";
            this.proceedButton.UseCustomBackColor = true;
            this.proceedButton.UseSelectable = true;
            this.proceedButton.UseStyleColors = true;
            this.proceedButton.Click += new System.EventHandler(this.proceedButton_Click);
            //
            // LoginPanel
            //
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.proceedButton);

            this.Name = "LoginPanel";
        }

        private MetroLabel titleLabel;
        private MetroLabel usernameLabel;
        private MetroLabel passwordLabel;
        private MetroTextBox usernameTextBox;
        private MetroTextBox passwordTextBox;
        private MetroButton proceedButton;
    }
}
