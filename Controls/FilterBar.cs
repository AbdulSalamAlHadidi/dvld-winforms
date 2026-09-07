using DVLD.Desktop.Theme;
using System;
using System.Windows.Forms;

namespace DVLD.Desktop.Controls
{
    public partial class FilterBar : UserControl
    {
        public event EventHandler<string> SearchRequested;
        public FilterBar()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            
            btnSearch.Click += (s, e) => RaiseSearch();
            
            //txtSearch.Click += (s, e) =>
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    RaiseSearch();
                }
            };

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;

            BackColor = theme.Surface;
            
            btnSearch.BackColor = theme.Border;
            btnSearch.ForeColor = theme.TextPrimary;
            
            txtSearch.BackColor = theme.InputBackground;
            txtSearch.ForeColor = theme.TextPrimary;
        }

        public string PlaceholderText
        { 
            set => txtSearch.Text = value;
        }

        private void RaiseSearch()
        {
            SearchRequested?.Invoke(this, txtSearch.Text.Trim());
        }
    }
}
