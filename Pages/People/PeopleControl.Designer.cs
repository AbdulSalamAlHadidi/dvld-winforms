namespace DVLD.Desktop.Pages.People
{
    partial class PeopleControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageHeader = new DVLD.Desktop.Controls.PageHeader();
            this.filterBar = new DVLD.Desktop.Controls.FilterBar();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.ActionText = "Button";
            this.pageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximumSize = new System.Drawing.Size(9999, 64);
            this.pageHeader.MinimumSize = new System.Drawing.Size(1, 64);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowAction = true;
            this.pageHeader.Size = new System.Drawing.Size(818, 64);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Title = "Label";
            // 
            // filterBar
            // 
            this.filterBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.filterBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterBar.Location = new System.Drawing.Point(0, 64);
            this.filterBar.Name = "filterBar";
            this.filterBar.Padding = new System.Windows.Forms.Padding(8);
            this.filterBar.Size = new System.Drawing.Size(818, 56);
            this.filterBar.TabIndex = 1;
            // 
            // dgvPeople
            // 
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPeople.Location = new System.Drawing.Point(0, 120);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.Size = new System.Drawing.Size(818, 506);
            this.dgvPeople.TabIndex = 2;
            // 
            // PeopleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.filterBar);
            this.Controls.Add(this.pageHeader);
            this.Name = "PeopleControl";
            this.Size = new System.Drawing.Size(818, 626);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PageHeader pageHeader;
        private Controls.FilterBar filterBar;
        private System.Windows.Forms.DataGridView dgvPeople;
    }
}
