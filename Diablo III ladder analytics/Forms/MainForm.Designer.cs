namespace Diablo_III_ladder_analytics
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aPIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorizationGroupBox = new System.Windows.Forms.GroupBox();
            this.notAuthorizedLabel = new System.Windows.Forms.Label();
            this.webSyncGroupBox = new System.Windows.Forms.GroupBox();
            this.syncButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.authorizationGroupBox.SuspendLayout();
            this.webSyncGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aPIToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aPIToolStripMenuItem
            // 
            this.aPIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAccountToolStripMenuItem,
            this.editAccountToolStripMenuItem,
            this.loadAccountToolStripMenuItem,
            this.deleteAccountToolStripMenuItem});
            this.aPIToolStripMenuItem.Name = "aPIToolStripMenuItem";
            this.aPIToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.aPIToolStripMenuItem.Text = "API";
            // 
            // newAccountToolStripMenuItem
            // 
            this.newAccountToolStripMenuItem.Name = "newAccountToolStripMenuItem";
            this.newAccountToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.newAccountToolStripMenuItem.Text = "New account";
            this.newAccountToolStripMenuItem.Click += new System.EventHandler(this.newAccountToolStripMenuItem_Click);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Enabled = false;
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.editAccountToolStripMenuItem.Text = "Edit account";
            // 
            // loadAccountToolStripMenuItem
            // 
            this.loadAccountToolStripMenuItem.Name = "loadAccountToolStripMenuItem";
            this.loadAccountToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.loadAccountToolStripMenuItem.Text = "Load account";
            this.loadAccountToolStripMenuItem.Click += new System.EventHandler(this.loadAccountToolStripMenuItem_Click);
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Enabled = false;
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteAccountToolStripMenuItem.Text = "Delete account";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // authorizationGroupBox
            // 
            this.authorizationGroupBox.Controls.Add(this.notAuthorizedLabel);
            this.authorizationGroupBox.Location = new System.Drawing.Point(637, 27);
            this.authorizationGroupBox.Name = "authorizationGroupBox";
            this.authorizationGroupBox.Size = new System.Drawing.Size(200, 100);
            this.authorizationGroupBox.TabIndex = 1;
            this.authorizationGroupBox.TabStop = false;
            this.authorizationGroupBox.Text = "Authorization status";
            // 
            // notAuthorizedLabel
            // 
            this.notAuthorizedLabel.AutoSize = true;
            this.notAuthorizedLabel.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAuthorizedLabel.ForeColor = System.Drawing.Color.Red;
            this.notAuthorizedLabel.Location = new System.Drawing.Point(28, 29);
            this.notAuthorizedLabel.Name = "notAuthorizedLabel";
            this.notAuthorizedLabel.Size = new System.Drawing.Size(153, 46);
            this.notAuthorizedLabel.TabIndex = 0;
            this.notAuthorizedLabel.Text = "Not \r\nauthorized!";
            this.notAuthorizedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // webSyncGroupBox
            // 
            this.webSyncGroupBox.Controls.Add(this.syncButton);
            this.webSyncGroupBox.Location = new System.Drawing.Point(13, 27);
            this.webSyncGroupBox.Name = "webSyncGroupBox";
            this.webSyncGroupBox.Size = new System.Drawing.Size(618, 100);
            this.webSyncGroupBox.TabIndex = 2;
            this.webSyncGroupBox.TabStop = false;
            this.webSyncGroupBox.Text = "Sync parameters";
            // 
            // syncButton
            // 
            this.syncButton.Location = new System.Drawing.Point(537, 62);
            this.syncButton.Name = "syncButton";
            this.syncButton.Size = new System.Drawing.Size(75, 32);
            this.syncButton.TabIndex = 0;
            this.syncButton.Text = "SYNC";
            this.syncButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(637, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 361);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 506);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.webSyncGroupBox);
            this.Controls.Add(this.authorizationGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Diablo III Ladder analyzer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.authorizationGroupBox.ResumeLayout(false);
            this.authorizationGroupBox.PerformLayout();
            this.webSyncGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.GroupBox authorizationGroupBox;
        private System.Windows.Forms.Label notAuthorizedLabel;
        private System.Windows.Forms.GroupBox webSyncGroupBox;
        private System.Windows.Forms.Button syncButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

