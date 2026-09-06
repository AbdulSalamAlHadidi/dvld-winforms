namespace DVLD.Desktop.Controls
{
    partial class DetailsCard
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
            this.lblCardTitle = new System.Windows.Forms.Label();
            this.tblRows = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lblCardTitle
            // 
            this.lblCardTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCardTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.lblCardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.lblCardTitle.Location = new System.Drawing.Point(20, 20);
            this.lblCardTitle.Name = "lblCardTitle";
            this.lblCardTitle.Size = new System.Drawing.Size(300, 30);
            this.lblCardTitle.TabIndex = 0;
            this.lblCardTitle.Text = "Card Title";
            // 
            // tblRows
            // 
            this.tblRows.AutoSize = true;
            this.tblRows.BackColor = System.Drawing.Color.Transparent;
            this.tblRows.ColumnCount = 2;
            this.tblRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tblRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblRows.Location = new System.Drawing.Point(20, 50);
            this.tblRows.Name = "tblRows";
            this.tblRows.RowCount = 2;
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblRows.Size = new System.Drawing.Size(300, 30);
            this.tblRows.TabIndex = 1;
            // 
            // DetailsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.Controls.Add(this.tblRows);
            this.Controls.Add(this.lblCardTitle);
            this.Margin = new System.Windows.Forms.Padding(12);
            this.Name = "DetailsCard";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Size = new System.Drawing.Size(340, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardTitle;
        private System.Windows.Forms.TableLayoutPanel tblRows;
    }
}
