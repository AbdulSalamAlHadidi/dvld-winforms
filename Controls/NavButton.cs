using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Desktop.Controls
{
    public partial class NavButton : UserControl
    {
        private bool _isActive;
        private static readonly Color ColorNormalBack = Color.FromArgb(33,33,33);
        private static readonly Color ColorHoverBack = Color.FromArgb(39, 39, 42);
        private static readonly Color ColorActiveBack = Color.FromArgb(109, 40, 217);
        private static readonly Color ColorNormalText = Color.FromArgb(161, 161, 170);
        private static readonly Color ColorActiveText = Color.FromArgb(249, 250, 251);
        public event EventHandler NavClicked;
        public NavButton()
        {
            InitializeComponent();
            WireEvents();
        }

        public string NavText 
        {
            get => lblText.Text;
            set => lblText.Text = value; 
        }

        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                ApplyVisualState();
            }
        }

        private void ApplyVisualState()
        {
            if(_isActive)
            {
                BackColor = ColorActiveBack;
                lblText.ForeColor = ColorActiveText;
                pnlAccent.Visible = true;
            }
            else
            {
                BackColor = ColorNormalBack;
                lblText.ForeColor = ColorNormalText;
                pnlAccent.Visible = false;
            }
        }

        private void WireEvents()
        {
            this.MouseEnter += NavButton_MouseEnter;
            this.MouseLeave += NavButton_MouseLeave;
            this.Click += NavButton_Click;

            lblText.MouseEnter += NavButton_MouseEnter;
            lblText.MouseLeave += NavButton_MouseLeave;
            lblText.Click += NavButton_Click;
        }

        private void NavButton_MouseEnter(object sender,EventArgs e)
        {
            if (!_isActive)
                BackColor = ColorHoverBack;
        }
        private void NavButton_MouseLeave(object sender,EventArgs e)
        {
            if (!_isActive)
                BackColor = ColorNormalBack;
        }
        private void NavButton_Click(object sender,EventArgs e)
        {
            NavClicked?.Invoke(this, EventArgs.Empty);
        }

    }
}
