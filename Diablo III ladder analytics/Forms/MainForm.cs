using System;
using System.Windows.Forms;
using Diablo_III_ladder_analytics.Classes;
using Diablo_III_ladder_analytics.Properties;

namespace Diablo_III_ladder_analytics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Resources.MainForm_exitToolStripMenuItem_Click_exit_app,
                                Resources.app_name,
                                MessageBoxButtons.YesNo, 
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAccountForm form = new NewAccountForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AppSettings.RefreshAppSettings();
        }

        private void loadAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountSelector form = new AccountSelector();
            form.ShowDialog();
        }

    }
}
