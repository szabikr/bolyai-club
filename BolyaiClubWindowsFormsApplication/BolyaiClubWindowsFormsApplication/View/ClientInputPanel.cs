using BolyaiClubWindowsFormsApplication.Controller;
using BolyaiClubWindowsFormsApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolyaiClubWindowsFormsApplication.View
{
    public partial class ClientInputPanel : ClientActionPanel
    {

        public ClientInputPanel() : base()
        {
            InitializeComponent();
        }

        protected bool IsValidData()
        {
            string name = nameTextBox.Text;
            string email = emailTextBox.Text;
            string mobile = mobileTextBox.Text;
            bool isNonProfit = nonProfitToggle.Checked;

            if (name == "" || email == "" || mobile == "")
            {
                warningLabel.Text = "All fields are required!";
                return false;
            }

            if (!IsValidEmail(email))
            {
                warningLabel.Text = "Enter a valid e-mail address!";
                return false;
            }

            if (!DatabaseManager.IsUniqEmail(email))
            {
                warningLabel.Text = "This e-mail address is already taken!";
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

    }
}
