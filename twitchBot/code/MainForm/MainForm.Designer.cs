namespace twitchBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarText = new System.Windows.Forms.ToolStripStatusLabel();
            this.label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chatDisplay = new System.Windows.Forms.TextBox();
            this.streamURI = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chatBox = new System.Windows.Forms.TextBox();
            this.chatButton = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.pleblistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pleblistToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.playerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBar = new System.Windows.Forms.Label();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            this.xbox = new System.Windows.Forms.PictureBox();
            this.minimizeBox = new System.Windows.Forms.PictureBox();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = false;
            this.statusBar.Dock = System.Windows.Forms.DockStyle.None;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarText});
            this.statusBar.Location = new System.Drawing.Point(1, 534);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(390, 21);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusBar";
            // 
            // statusBarText
            // 
            this.statusBarText.BackColor = System.Drawing.SystemColors.MenuBar;
            this.statusBarText.Name = "statusBarText";
            this.statusBarText.Size = new System.Drawing.Size(118, 16);
            this.statusBarText.Text = "toolStripStatusLabel1";
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label.Location = new System.Drawing.Point(249, 65);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(131, 18);
            this.label.TabIndex = 2;
            this.label.Text = "label1";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chatDisplay
            // 
            this.chatDisplay.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.chatDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatDisplay.ForeColor = System.Drawing.SystemColors.Control;
            this.chatDisplay.Location = new System.Drawing.Point(12, 86);
            this.chatDisplay.Multiline = true;
            this.chatDisplay.Name = "chatDisplay";
            this.chatDisplay.Size = new System.Drawing.Size(368, 416);
            this.chatDisplay.TabIndex = 3;
            // 
            // streamURI
            // 
            this.streamURI.AutoSize = true;
            this.streamURI.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamURI.LinkColor = System.Drawing.Color.LimeGreen;
            this.streamURI.Location = new System.Drawing.Point(12, 65);
            this.streamURI.Name = "streamURI";
            this.streamURI.Size = new System.Drawing.Size(88, 18);
            this.streamURI.TabIndex = 4;
            this.streamURI.TabStop = true;
            this.streamURI.Text = "linkLabel1";
            this.streamURI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.streamURI_LinkClicked);
            // 
            // timer2
            // 
            this.timer2.Interval = 1800000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chatBox
            // 
            this.chatBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBox.Location = new System.Drawing.Point(15, 510);
            this.chatBox.Name = "chatBox";
            this.chatBox.Size = new System.Drawing.Size(281, 16);
            this.chatBox.TabIndex = 5;
            // 
            // chatButton
            // 
            this.chatButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatButton.Location = new System.Drawing.Point(305, 508);
            this.chatButton.Margin = new System.Windows.Forms.Padding(0);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(75, 20);
            this.chatButton.TabIndex = 6;
            this.chatButton.Text = "Send";
            this.chatButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chatButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.AutoSize = false;
            this.mainMenu.BackColor = System.Drawing.SystemColors.GrayText;
            this.mainMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pleblistToolStripMenuItem,
            this.pleblistToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(1, 1);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(6, 32, 0, 2);
            this.mainMenu.Size = new System.Drawing.Size(390, 53);
            this.mainMenu.TabIndex = 7;
            this.mainMenu.Text = "menuStrip1";
            // 
            // pleblistToolStripMenuItem
            // 
            this.pleblistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reconnectToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.pleblistToolStripMenuItem.Name = "pleblistToolStripMenuItem";
            this.pleblistToolStripMenuItem.Size = new System.Drawing.Size(54, 19);
            this.pleblistToolStripMenuItem.Text = "Twitch";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.reconnectToolStripMenuItem.Text = "Reconnect";
            this.reconnectToolStripMenuItem.Click += new System.EventHandler(this.reconnectToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pleblistToolStripMenuItem1
            // 
            this.pleblistToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerToolStripMenuItem,
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.pleblistToolStripMenuItem1.Name = "pleblistToolStripMenuItem1";
            this.pleblistToolStripMenuItem1.Size = new System.Drawing.Size(57, 19);
            this.pleblistToolStripMenuItem1.Text = "Pleblist";
            // 
            // playerToolStripMenuItem
            // 
            this.playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            this.playerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playerToolStripMenuItem.Text = "Player";
            this.playerToolStripMenuItem.Click += new System.EventHandler(this.playerToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.helpToolStripMenuItem.Text = "Options";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // titleBar
            // 
            this.titleBar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.Location = new System.Drawing.Point(38, 9);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(305, 15);
            this.titleBar.TabIndex = 8;
            this.titleBar.Text = "Window Title";
            // 
            // windowIcon
            // 
            this.windowIcon.ErrorImage = ((System.Drawing.Image)(resources.GetObject("windowIcon.ErrorImage")));
            this.windowIcon.Image = global::twitchBot.Properties.Resources.MrDestructoidPNG;
            this.windowIcon.InitialImage = ((System.Drawing.Image)(resources.GetObject("windowIcon.InitialImage")));
            this.windowIcon.Location = new System.Drawing.Point(9, 7);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(20, 20);
            this.windowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.windowIcon.TabIndex = 10;
            this.windowIcon.TabStop = false;
            // 
            // xbox
            // 
            this.xbox.Image = global::twitchBot.Properties.Resources.x4;
            this.xbox.Location = new System.Drawing.Point(367, 7);
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(16, 16);
            this.xbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xbox.TabIndex = 11;
            this.xbox.TabStop = false;
            this.xbox.Click += new System.EventHandler(this.xbox_Click);
            // 
            // minimizeBox
            // 
            this.minimizeBox.Image = global::twitchBot.Properties.Resources._3;
            this.minimizeBox.Location = new System.Drawing.Point(349, 7);
            this.minimizeBox.Name = "minimizeBox";
            this.minimizeBox.Size = new System.Drawing.Size(16, 16);
            this.minimizeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimizeBox.TabIndex = 12;
            this.minimizeBox.TabStop = false;
            this.minimizeBox.Click += new System.EventHandler(this.minimizeBox_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(392, 556);
            this.Controls.Add(this.minimizeBox);
            this.Controls.Add(this.xbox);
            this.Controls.Add(this.windowIcon);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.chatBox);
            this.Controls.Add(this.streamURI);
            this.Controls.Add(this.chatDisplay);
            this.Controls.Add(this.label);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Vunjobot Pleblist";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private youtubePlaylist yt;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarText;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox chatDisplay;
        private System.Windows.Forms.LinkLabel streamURI;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox chatBox;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem pleblistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label titleBar;
        private System.Windows.Forms.PictureBox windowIcon;
        private System.Windows.Forms.PictureBox xbox;
        private System.Windows.Forms.PictureBox minimizeBox;
        private System.Windows.Forms.ToolStripMenuItem pleblistToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

