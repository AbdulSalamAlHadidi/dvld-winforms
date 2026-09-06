namespace DVLD.Desktop.Pages.People
{
    partial class PersonDetailsControl
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
            this.flowCards = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // pageHeader
            // 
            this.pageHeader.ActionText = "Edit";
            this.pageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.pageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeader.Location = new System.Drawing.Point(0, 0);
            this.pageHeader.MaximumSize = new System.Drawing.Size(9999, 64);
            this.pageHeader.MinimumSize = new System.Drawing.Size(1, 64);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.ShowAction = true;
            this.pageHeader.ShowBackButton = true;
            this.pageHeader.Size = new System.Drawing.Size(841, 64);
            this.pageHeader.TabIndex = 0;
            this.pageHeader.Title = "Person Details";
            // 
            // flowCards
            // 
            this.flowCards.AutoScroll = true;
            this.flowCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowCards.Location = new System.Drawing.Point(0, 64);
            this.flowCards.Name = "flowCards";
            this.flowCards.Padding = new System.Windows.Forms.Padding(20);
            this.flowCards.Size = new System.Drawing.Size(841, 271);
            this.flowCards.TabIndex = 1;
            // 
            // PersonDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Controls.Add(this.flowCards);
            this.Controls.Add(this.pageHeader);
            this.Name = "PersonDetailsControl";
            this.Size = new System.Drawing.Size(841, 335);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.PageHeader pageHeader;
        private System.Windows.Forms.FlowLayoutPanel flowCards;
    }
}
