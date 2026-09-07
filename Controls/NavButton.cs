using DVLD.Desktop.Theme;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Desktop.Controls
{
    public partial class NavButton : UserControl
    {
        private bool _isActive;
        private bool _isHovered;
        public event EventHandler NavClicked;
        public NavButton()
        {
            InitializeComponent();
            WireEvents();
            ApplyTheme();
        
        // To avoid being called every time ApplyTheme is invoked.
            pnlAccent.BackColor = ThemeManager.Current.Accent;

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
                if (_isActive != value)
                {
                    _isActive = value;
                    ApplyTheme();
                }
            }
        }

        private void WireEvents()
        {
            this.MouseEnter += (s, e) => { _isHovered = true; ApplyTheme(); };
            this.MouseLeave += (s, e) => { _isHovered = false; ApplyTheme(); };
            this.Click += (s, e) => NavClicked?.Invoke(this, EventArgs.Empty);

            lblText.MouseEnter += (s, e) => { _isHovered = true; ApplyTheme(); };
            lblText.MouseLeave += (s, e) => { _isHovered = false; ApplyTheme(); };
            lblText.Click += (s, e) => NavClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;

            BackColor = _isActive ? theme.Primary : (_isHovered ? theme.HoverBackground : theme.Sidebar);
            lblText.ForeColor = _isActive ? theme.TextPrimary : theme.TextSecondary;
            pnlAccent.Visible = _isActive;
        }       
    }
}
