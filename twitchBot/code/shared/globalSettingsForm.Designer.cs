namespace twitchBot {
    partial class globalSettingsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.displayCheckbox = new System.Windows.Forms.CheckBox();
            this.displayComboBox = new System.Windows.Forms.ComboBox();
            this.groupBoxDisplay = new System.Windows.Forms.GroupBox();
            this.groupBoxNetworking = new System.Windows.Forms.GroupBox();
            this.urilabel = new System.Windows.Forms.Label();
            this.controlUrlBox = new System.Windows.Forms.TextBox();
            this.offlineCheckbox = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.windowTitle = new System.Windows.Forms.Label();
            this.windowIcon = new System.Windows.Forms.PictureBox();
            this.xbox = new System.Windows.Forms.PictureBox();
            this.groupBoxDisplay.SuspendLayout();
            this.groupBoxNetworking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).BeginInit();
            this.SuspendLayout();
            // 
            // displayCheckbox
            // 
            this.displayCheckbox.AutoSize = true;
            this.displayCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayCheckbox.Location = new System.Drawing.Point(6, 19);
            this.displayCheckbox.Name = "displayCheckbox";
            this.displayCheckbox.Size = new System.Drawing.Size(88, 17);
            this.displayCheckbox.TabIndex = 0;
            this.displayCheckbox.Text = "Prefer Display";
            this.displayCheckbox.UseVisualStyleBackColor = true;
            // 
            // displayComboBox
            // 
            this.displayComboBox.FormattingEnabled = true;
            this.displayComboBox.Location = new System.Drawing.Point(6, 42);
            this.displayComboBox.Name = "displayComboBox";
            this.displayComboBox.Size = new System.Drawing.Size(172, 21);
            this.displayComboBox.TabIndex = 1;
            // 
            // groupBoxDisplay
            // 
            this.groupBoxDisplay.Controls.Add(this.displayComboBox);
            this.groupBoxDisplay.Controls.Add(this.displayCheckbox);
            this.groupBoxDisplay.Location = new System.Drawing.Point(12, 38);
            this.groupBoxDisplay.Name = "groupBoxDisplay";
            this.groupBoxDisplay.Size = new System.Drawing.Size(185, 70);
            this.groupBoxDisplay.TabIndex = 2;
            this.groupBoxDisplay.TabStop = false;
            this.groupBoxDisplay.Text = "Display";
            // 
            // groupBoxNetworking
            // 
            this.groupBoxNetworking.Controls.Add(this.urilabel);
            this.groupBoxNetworking.Controls.Add(this.controlUrlBox);
            this.groupBoxNetworking.Controls.Add(this.offlineCheckbox);
            this.groupBoxNetworking.Location = new System.Drawing.Point(13, 114);
            this.groupBoxNetworking.Name = "groupBoxNetworking";
            this.groupBoxNetworking.Size = new System.Drawing.Size(184, 75);
            this.groupBoxNetworking.TabIndex = 3;
            this.groupBoxNetworking.TabStop = false;
            this.groupBoxNetworking.Text = "Networking";
            // 
            // urilabel
            // 
            this.urilabel.AutoSize = true;
            this.urilabel.Location = new System.Drawing.Point(6, 47);
            this.urilabel.Name = "urilabel";
            this.urilabel.Size = new System.Drawing.Size(62, 13);
            this.urilabel.TabIndex = 2;
            this.urilabel.Text = "Script URL:";
            // 
            // controlUrlBox
            // 
            this.controlUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.controlUrlBox.Location = new System.Drawing.Point(74, 47);
            this.controlUrlBox.Name = "controlUrlBox";
            this.controlUrlBox.Size = new System.Drawing.Size(103, 13);
            this.controlUrlBox.TabIndex = 1;
            // 
            // offlineCheckbox
            // 
            this.offlineCheckbox.AutoSize = true;
            this.offlineCheckbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.offlineCheckbox.Location = new System.Drawing.Point(7, 20);
            this.offlineCheckbox.Name = "offlineCheckbox";
            this.offlineCheckbox.Size = new System.Drawing.Size(83, 17);
            this.offlineCheckbox.TabIndex = 0;
            this.offlineCheckbox.Text = "Offline Mode";
            this.offlineCheckbox.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(41, 195);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(122, 195);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // windowTitle
            // 
            this.windowTitle.Location = new System.Drawing.Point(33, 2);
            this.windowTitle.Name = "windowTitle";
            this.windowTitle.Size = new System.Drawing.Size(142, 33);
            this.windowTitle.TabIndex = 6;
            this.windowTitle.Text = "Settings";
            this.windowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // windowIcon
            // 
            this.windowIcon.Image = global::twitchBot.Properties.Resources.MrDestructoidPNG;
            this.windowIcon.Location = new System.Drawing.Point(7, 9);
            this.windowIcon.Name = "windowIcon";
            this.windowIcon.Size = new System.Drawing.Size(20, 20);
            this.windowIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.windowIcon.TabIndex = 7;
            this.windowIcon.TabStop = false;
            // 
            // xbox
            // 
            this.xbox.Image = global::twitchBot.Properties.Resources.x4;
            this.xbox.Location = new System.Drawing.Point(181, 10);
            this.xbox.Name = "xbox";
            this.xbox.Size = new System.Drawing.Size(16, 16);
            this.xbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.xbox.TabIndex = 8;
            this.xbox.TabStop = false;
            this.xbox.Click += new System.EventHandler(this.xbox_Click);
            // 
            // globalSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 230);
            this.Controls.Add(this.xbox);
            this.Controls.Add(this.windowIcon);
            this.Controls.Add(this.windowTitle);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBoxNetworking);
            this.Controls.Add(this.groupBoxDisplay);
            this.Name = "globalSettingsForm";
            this.Text = "Settings";
            this.groupBoxDisplay.ResumeLayout(false);
            this.groupBoxDisplay.PerformLayout();
            this.groupBoxNetworking.ResumeLayout(false);
            this.groupBoxNetworking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.windowIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox displayCheckbox;
        private System.Windows.Forms.ComboBox displayComboBox;
        private System.Windows.Forms.GroupBox groupBoxDisplay;
        private System.Windows.Forms.GroupBox groupBoxNetworking;
        private System.Windows.Forms.TextBox controlUrlBox;
        private System.Windows.Forms.CheckBox offlineCheckbox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label windowTitle;
        private System.Windows.Forms.PictureBox windowIcon;
        private System.Windows.Forms.PictureBox xbox;
        private System.Windows.Forms.Label urilabel;
    }
}