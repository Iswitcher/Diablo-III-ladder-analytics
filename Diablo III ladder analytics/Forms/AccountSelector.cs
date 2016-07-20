using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Diablo_III_ladder_analytics.Classes;

namespace Diablo_III_ladder_analytics
{
    public partial class AccountSelector : Form
    {
        public AccountSelector()
        {
            InitializeComponent();
        }

        private void AccountSelector_Load(object sender, EventArgs e)
        {
            var accounts = AccountController.GetAccounts();
            foreach (var account in accounts)
            {
                accountsListBox.Items.Add(account.Username);
            }
        }

        private void accountsListBox_DoubleClick(object sender, EventArgs e)
        {
            var accounts = AccountController.GetAccounts();
            var selectedUser = accountsListBox.SelectedItem.ToString();
            var clientId = accounts.Where(w => w.Username == selectedUser).Select(s => s.ClientId).ToString();
            var clientSecretId = accounts.Where(w => w.Username == selectedUser).Select(s => s.ClientSecretId).ToString();
            //MainForm.AuthorizeUser(selectedUser,clientId,clientSecretId);

            Close();
        }

    }
}
