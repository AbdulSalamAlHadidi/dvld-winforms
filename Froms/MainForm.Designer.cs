namespace DVLD.Desktop.Froms
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
            this.pnlSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTopbar = new System.Windows.Forms.Panel();
            this.lblPageTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblDVLD = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavPeople = new System.Windows.Forms.Button();
            this.btnNavDrivers = new System.Windows.Forms.Button();
            this.btnNavApplications = new System.Windows.Forms.Button();
            this.btnNavLicenses = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.pnlSidebar.SuspendLayout();
            this.pnlTopbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.pnlSidebar.Controls.Add(this.lblDVLD);
            this.pnlSidebar.Controls.Add(this.btnNavDashboard);
            this.pnlSidebar.Controls.Add(this.btnNavPeople);
            this.pnlSidebar.Controls.Add(this.btnNavDrivers);
            this.pnlSidebar.Controls.Add(this.btnNavApplications);
            this.pnlSidebar.Controls.Add(this.btnNavLicenses);
            this.pnlSidebar.Controls.Add(this.btnNavUsers);
            this.pnlSidebar.Controls.Add(this.btnNavSettings);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(16, 20, 16, 20);
            this.pnlSidebar.Size = new System.Drawing.Size(250, 681);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlTopbar
            // 
            this.pnlTopbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlTopbar.Controls.Add(this.lblPageTitle);
            this.pnlTopbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopbar.Location = new System.Drawing.Point(250, 0);
            this.pnlTopbar.Name = "pnlTopbar";
            this.pnlTopbar.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.pnlTopbar.Size = new System.Drawing.Size(934, 70);
            this.pnlTopbar.TabIndex = 1;
            // 
            // lblPageTitle
            // 
            this.lblPageTitle.AutoSize = true;
            this.lblPageTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblPageTitle.Location = new System.Drawing.Point(24, 22);
            this.lblPageTitle.Name = "lblPageTitle";
            this.lblPageTitle.Size = new System.Drawing.Size(118, 30);
            this.lblPageTitle.TabIndex = 0;
            this.lblPageTitle.Text = "Dashboard";
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(250, 70);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(24);
            this.pnlContent.Size = new System.Drawing.Size(934, 611);
            this.pnlContent.TabIndex = 2;
            // 
            // lblDVLD
            // 
            this.lblDVLD.AutoSize = true;
            this.lblDVLD.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDVLD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblDVLD.Location = new System.Drawing.Point(19, 20);
            this.lblDVLD.Name = "lblDVLD";
            this.lblDVLD.Size = new System.Drawing.Size(204, 90);
            this.lblDVLD.TabIndex = 1;
            this.lblDVLD.Text = "DVLD \nDriver & Vehicle License Department";
            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavDashboard.Location = new System.Drawing.Point(19, 113);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavDashboard.Size = new System.Drawing.Size(194, 48);
            this.btnNavDashboard.TabIndex = 2;
            this.btnNavDashboard.Text = "Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = true;
            this.btnNavDashboard.Click += new System.EventHandler(this.btnNavDashboard_Click);
            // 
            // btnNavPeople
            // 
            this.btnNavPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavPeople.FlatAppearance.BorderSize = 0;
            this.btnNavPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavPeople.Location = new System.Drawing.Point(19, 167);
            this.btnNavPeople.Name = "btnNavPeople";
            this.btnNavPeople.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavPeople.Size = new System.Drawing.Size(194, 48);
            this.btnNavPeople.TabIndex = 3;
            this.btnNavPeople.Text = "People";
            this.btnNavPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPeople.UseVisualStyleBackColor = true;
            this.btnNavPeople.Click += new System.EventHandler(this.btnNavPeople_Click);
            // 
            // btnNavDrivers
            // 
            this.btnNavDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavDrivers.FlatAppearance.BorderSize = 0;
            this.btnNavDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDrivers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavDrivers.Location = new System.Drawing.Point(19, 221);
            this.btnNavDrivers.Name = "btnNavDrivers";
            this.btnNavDrivers.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavDrivers.Size = new System.Drawing.Size(194, 48);
            this.btnNavDrivers.TabIndex = 4;
            this.btnNavDrivers.Text = "Drivers";
            this.btnNavDrivers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDrivers.UseVisualStyleBackColor = true;
            this.btnNavDrivers.Click += new System.EventHandler(this.btnNavDrivers_Click);
            // 
            // btnNavApplications
            // 
            this.btnNavApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavApplications.FlatAppearance.BorderSize = 0;
            this.btnNavApplications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavApplications.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavApplications.Location = new System.Drawing.Point(19, 275);
            this.btnNavApplications.Name = "btnNavApplications";
            this.btnNavApplications.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavApplications.Size = new System.Drawing.Size(194, 48);
            this.btnNavApplications.TabIndex = 5;
            this.btnNavApplications.Text = "Applications";
            this.btnNavApplications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavApplications.UseVisualStyleBackColor = true;
            this.btnNavApplications.Click += new System.EventHandler(this.btnNavApplications_Click);
            // 
            // btnNavLicenses
            // 
            this.btnNavLicenses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavLicenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavLicenses.FlatAppearance.BorderSize = 0;
            this.btnNavLicenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLicenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavLicenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavLicenses.Location = new System.Drawing.Point(19, 329);
            this.btnNavLicenses.Name = "btnNavLicenses";
            this.btnNavLicenses.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavLicenses.Size = new System.Drawing.Size(194, 48);
            this.btnNavLicenses.TabIndex = 6;
            this.btnNavLicenses.Text = "Licenses";
            this.btnNavLicenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLicenses.UseVisualStyleBackColor = true;
            this.btnNavLicenses.Click += new System.EventHandler(this.btnNavLicenses_Click);
            // 
            // btnNavUsers
            // 
            this.btnNavUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavUsers.Location = new System.Drawing.Point(19, 383);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavUsers.Size = new System.Drawing.Size(194, 48);
            this.btnNavUsers.TabIndex = 7;
            this.btnNavUsers.Text = "Users";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = true;
            this.btnNavUsers.Click += new System.EventHandler(this.btnNavUsers_Click);
            // 
            // btnNavSettings
            // 
            this.btnNavSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNavSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.btnNavSettings.Location = new System.Drawing.Point(19, 437);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.btnNavSettings.Size = new System.Drawing.Size(194, 48);
            this.btnNavSettings.TabIndex = 8;
            this.btnNavSettings.Text = "Settings";
            this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.UseVisualStyleBackColor = true;
            this.btnNavSettings.Click += new System.EventHandler(this.btnNavSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopbar);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1200, 720);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DVLD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlTopbar.ResumeLayout(false);
            this.pnlTopbar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSidebar;
        private System.Windows.Forms.Panel pnlTopbar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblDVLD;
        private System.Windows.Forms.Button btnNavDashboard;
        private System.Windows.Forms.Button btnNavPeople;
        private System.Windows.Forms.Button btnNavDrivers;
        private System.Windows.Forms.Button btnNavApplications;
        private System.Windows.Forms.Button btnNavLicenses;
        private System.Windows.Forms.Button btnNavUsers;
        private System.Windows.Forms.Button btnNavSettings;
    }
}