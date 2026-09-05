namespace DVLD.Desktop.Controls
{
    partial class NavButton
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
            this.lblText = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(170)))));
            this.lblText.Location = new System.Drawing.Point(0, 0);
            this.lblText.Name = "lblText";
            this.lblText.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblText.Size = new System.Drawing.Size(250, 48);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Nav Item ";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlAccent
            // 
            this.pnlAccent.BackColor = System.Drawing.Color.Red;
            this.pnlAccent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(4, 48);
            this.pnlAccent.TabIndex = 1;
            this.pnlAccent.Visible = false;
            // 
            // NavButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.lblText);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NavButton";
            this.Size = new System.Drawing.Size(250, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel pnlAccent;
    }
}
