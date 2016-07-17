using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diablo_III_ladder_analytics.Properties;

namespace Diablo_III_ladder_analytics
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            battleNetLinkLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("https://dev.battle.net/");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            clientIdTextBox.BackColor = Color.White;
            clientSecretIdTextbox.BackColor = Color.White;
            usernameTextBox.BackColor = Color.White;

            if (clientIdTextBox.Text == "") clientIdTextBox.BackColor = Color.IndianRed;
            if (clientSecretIdTextbox.Text == "") clientSecretIdTextbox.BackColor = Color.IndianRed;
            if (usernameTextBox.Text == "") usernameTextBox.BackColor = Color.IndianRed;

            if (clientIdTextBox.Text != ""&& clientSecretIdTextbox.Text != ""&&usernameTextBox.Text != "")
            {
                string clientId = clientIdTextBox.Text;
                string clientSecretId = clientSecretIdTextbox.Text;
                string username = usernameTextBox.Text;

                AccountController.AddAccount(username, clientId, clientSecretId);

                MessageBox.Show(string.Format(Resources.NewAccountForm_accountCreatedText,username),Resources.NewAccountForm_accountCreated);
                Close();
            }
            return;
        }

        private void clientIdTextBox_Enter(object sender, EventArgs e)
        {
            clientIdTextBox.BackColor = Color.White;
        }

        private void clientSecretIdTextbox_Enter(object sender, EventArgs e)
        {
            clientSecretIdTextbox.BackColor = Color.White;
        }

        private void usernameTextBox_Enter(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
        }
    }
}
