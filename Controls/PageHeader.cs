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
