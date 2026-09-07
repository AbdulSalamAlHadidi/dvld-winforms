using DVLD.Desktop.Theme;
using System;
using System.Windows.Forms;

namespace DVLD.Desktop.Controls
{
    public partial class PageHeader : UserControl
    {
        public event EventHandler ActionClicked;
        public event EventHandler BackClicked;
        public PageHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
            btnAction.Click += (s, e) => ActionClicked?.Invoke(this, EventArgs.Empty);
            btnBack.Click += (s, e) => BackClicked?.Invoke(this, EventArgs.Empty);

            ApplyTheme();
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;

            BackColor = theme.Background;
        // Action Button
            btnAction.BackColor = theme.Primary;
            btnAction.ForeColor = theme.TextPrimary;
        // Back Button
            btnBack.BackColor = theme.Background;
            btnBack.ForeColor = theme.TextPrimary;
        // Title Label
            lblTitle.ForeColor = theme.TextPrimary;
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string ActionText
        {
            get => btnAction.Text;
            set => btnAction.Text = value;
        }

        public bool ShowAction
        {
            get => btnAction.Visible;
            set => btnAction.Visible = value;
        }

        public bool ShowBackButton
        {
            get => btnBack.Visible;
            set => btnBack.Visible = value;
        }
    }
}
