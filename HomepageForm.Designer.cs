﻿namespace shopManager
{
    partial class HomepageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomepageForm));
            panel1 = new Panel();
            homepageLabel = new Label();
            notificationPictureBox = new PictureBox();
            profilePictureBox = new PictureBox();
            inventoryButton = new Button();
            stockButton = new Button();
            addprodButton = new Button();
            hiLabel = new Label();
            panel2 = new Panel();
            logoutButton = new Button();
            settingsPictureBox = new PictureBox();
            accountPictureBox = new PictureBox();
            locationPictureBox = new PictureBox();
            homePictureBox = new PictureBox();
            settingsLabel = new Label();
            logoutLabel = new Label();
            accountLabel = new Label();
            locationLabel = new Label();
            homeLabel = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)locationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homePictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Controls.Add(homepageLabel);
            panel1.Controls.Add(notificationPictureBox);
            panel1.Controls.Add(profilePictureBox);
            panel1.Controls.Add(inventoryButton);
            panel1.Controls.Add(stockButton);
            panel1.Controls.Add(addprodButton);
            panel1.Controls.Add(hiLabel);
            panel1.Location = new Point(216, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(1640, 867);
            panel1.TabIndex = 0;
            // 
            // homepageLabel
            // 
            homepageLabel.AutoSize = true;
            homepageLabel.BackColor = Color.Transparent;
            homepageLabel.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            homepageLabel.ForeColor = Color.LightGray;
            homepageLabel.Location = new Point(66, 66);
            homepageLabel.Name = "homepageLabel";
            homepageLabel.Size = new Size(241, 52);
            homepageLabel.TabIndex = 7;
            homepageLabel.Text = "Homepage";
            // 
            // notificationPictureBox
            // 
            notificationPictureBox.BackgroundImage = Properties.Resources.noification;
            notificationPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            notificationPictureBox.Location = new Point(1518, 0);
            notificationPictureBox.Name = "notificationPictureBox";
            notificationPictureBox.Size = new Size(50, 46);
            notificationPictureBox.TabIndex = 6;
            notificationPictureBox.TabStop = false;
            // 
            // profilePictureBox
            // 
            profilePictureBox.BackgroundImage = Properties.Resources.profile;
            profilePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            profilePictureBox.Location = new Point(1586, 0);
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(51, 46);
            profilePictureBox.TabIndex = 5;
            profilePictureBox.TabStop = false;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(15, 16, 43);
            inventoryButton.FlatStyle = FlatStyle.Popup;
            inventoryButton.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            inventoryButton.ForeColor = Color.LightGray;
            inventoryButton.Location = new Point(1146, 233);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(453, 119);
            inventoryButton.TabIndex = 4;
            inventoryButton.Text = "Inventory";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // stockButton
            // 
            stockButton.BackColor = Color.FromArgb(15, 16, 43);
            stockButton.FlatStyle = FlatStyle.Popup;
            stockButton.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            stockButton.ForeColor = Color.LightGray;
            stockButton.Location = new Point(602, 233);
            stockButton.Name = "stockButton";
            stockButton.Size = new Size(460, 119);
            stockButton.TabIndex = 3;
            stockButton.Text = "Stock";
            stockButton.UseVisualStyleBackColor = false;
            // 
            // addprodButton
            // 
            addprodButton.BackColor = Color.FromArgb(15, 16, 43);
            addprodButton.FlatStyle = FlatStyle.Popup;
            addprodButton.Font = new Font("Arial Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addprodButton.ForeColor = Color.LightGray;
            addprodButton.Location = new Point(79, 233);
            addprodButton.Name = "addprodButton";
            addprodButton.Size = new Size(448, 119);
            addprodButton.TabIndex = 2;
            addprodButton.Text = "Add Product";
            addprodButton.UseVisualStyleBackColor = false;
            addprodButton.Click += addprodButton_Click;
            // 
            // hiLabel
            // 
            hiLabel.AutoSize = true;
            hiLabel.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            hiLabel.ForeColor = Color.LightGray;
            hiLabel.Location = new Point(111, 126);
            hiLabel.Name = "hiLabel";
            hiLabel.Size = new Size(117, 27);
            hiLabel.TabIndex = 1;
            hiLabel.Text = "Hi,Employee";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(logoutButton);
            panel2.Controls.Add(settingsPictureBox);
            panel2.Controls.Add(accountPictureBox);
            panel2.Controls.Add(locationPictureBox);
            panel2.Controls.Add(homePictureBox);
            panel2.Controls.Add(settingsLabel);
            panel2.Controls.Add(logoutLabel);
            panel2.Controls.Add(accountLabel);
            panel2.Controls.Add(locationLabel);
            panel2.Controls.Add(homeLabel);
            panel2.Location = new Point(12, 29);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 867);
            panel2.TabIndex = 5;
            // 
            // logoutButton
            // 
            logoutButton.BackgroundImage = Properties.Resources.logout;
            logoutButton.BackgroundImageLayout = ImageLayout.Zoom;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.ForeColor = Color.FromArgb(15, 16, 43);
            logoutButton.Location = new Point(11, 213);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(36, 34);
            logoutButton.TabIndex = 8;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // settingsPictureBox
            // 
            settingsPictureBox.BackgroundImage = Properties.Resources.settings;
            settingsPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            settingsPictureBox.Location = new Point(11, 799);
            settingsPictureBox.Name = "settingsPictureBox";
            settingsPictureBox.Size = new Size(39, 46);
            settingsPictureBox.TabIndex = 5;
            settingsPictureBox.TabStop = false;
            // 
            // accountPictureBox
            // 
            accountPictureBox.BackgroundImage = Properties.Resources.profile;
            accountPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            accountPictureBox.Location = new Point(11, 126);
            accountPictureBox.Name = "accountPictureBox";
            accountPictureBox.Size = new Size(34, 27);
            accountPictureBox.TabIndex = 5;
            accountPictureBox.TabStop = false;
            // 
            // locationPictureBox
            // 
            locationPictureBox.BackgroundImage = Properties.Resources.locations;
            locationPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            locationPictureBox.Location = new Point(9, 91);
            locationPictureBox.Name = "locationPictureBox";
            locationPictureBox.Size = new Size(41, 27);
            locationPictureBox.TabIndex = 5;
            locationPictureBox.TabStop = false;
            // 
            // homePictureBox
            // 
            homePictureBox.BackColor = Color.Transparent;
            homePictureBox.BackgroundImage = (Image)resources.GetObject("homePictureBox.BackgroundImage");
            homePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            homePictureBox.Location = new Point(11, 57);
            homePictureBox.Name = "homePictureBox";
            homePictureBox.Size = new Size(36, 24);
            homePictureBox.TabIndex = 5;
            homePictureBox.TabStop = false;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            settingsLabel.ForeColor = Color.LightGray;
            settingsLabel.Location = new Point(51, 812);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(69, 24);
            settingsLabel.TabIndex = 4;
            settingsLabel.Text = "Settings";
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            logoutLabel.ForeColor = Color.LightGray;
            logoutLabel.Location = new Point(51, 217);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(69, 24);
            logoutLabel.TabIndex = 3;
            logoutLabel.Text = "Log Out";
            // 
            // accountLabel
            // 
            accountLabel.AutoSize = true;
            accountLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            accountLabel.ForeColor = Color.LightGray;
            accountLabel.Location = new Point(51, 129);
            accountLabel.Name = "accountLabel";
            accountLabel.Size = new Size(69, 24);
            accountLabel.TabIndex = 2;
            accountLabel.Text = "Account";
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            locationLabel.ForeColor = Color.LightGray;
            locationLabel.Location = new Point(51, 94);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new Size(79, 24);
            locationLabel.TabIndex = 1;
            locationLabel.Text = "Locations";
            // 
            // homeLabel
            // 
            homeLabel.AutoSize = true;
            homeLabel.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeLabel.ForeColor = Color.LightGray;
            homeLabel.Location = new Point(51, 57);
            homeLabel.Name = "homeLabel";
            homeLabel.Size = new Size(91, 24);
            homeLabel.TabIndex = 0;
            homeLabel.Text = "Homepage";
            // 
            // HomepageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Screenshot__54_;
            ClientSize = new Size(1883, 908);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "HomepageForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomepageForm";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)notificationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)profilePictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)settingsPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)locationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)homePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label hiLabel;
        private Button addprodButton;
        private Button inventoryButton;
        private Button stockButton;
        private Panel panel2;
        private Label homeLabel;
        private Label locationLabel;
        private Label settingsLabel;
        private Label logoutLabel;
        private Label accountLabel;
        private PictureBox homePictureBox;
        private PictureBox locationPictureBox;
        private PictureBox settingsPictureBox;
        private PictureBox accountPictureBox;
        private PictureBox profilePictureBox;
        private PictureBox notificationPictureBox;
        private Label homepageLabel;
        private Button logoutButton;
    }
}