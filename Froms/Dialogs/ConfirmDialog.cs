using DVLD.Desktop.Theme;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD.Desktop.Froms.Dialogs
{
    public partial class ConfirmDialog : Form
    {
        public ConfirmDialog(string title, string message, string confirmText = "Delete", string cancelText = "Cancel")
        {
            InitializeComponent();

            Text = title;
            lblMessage.Text = message;
            btnConfirm.Text = confirmText;
            btnCancel.Text = cancelText;

            ApplyTheme();

            btnConfirm.Click += (s, e) => { DialogResult = DialogResult.Yes; Close(); };
            btnCancel.Click += (s, e) => { DialogResult = DialogResult.Cancel; Close(); };
        }

        public static bool Confirm(string title, string message, string confirmText = "Delete")
        {
            using (var dialog = new ConfirmDialog(title, message, confirmText))
            {
                return dialog.ShowDialog() == DialogResult.Yes;
            }
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;

            BackColor = theme.Surface;
            
            lblMessage.ForeColor = theme.TextPrimary;

            btnConfirm.BackColor = theme.Danger;
            btnConfirm.ForeColor = theme.TextPrimary;
            
            btnCancel.BackColor = theme.Border;
            btnCancel.ForeColor = theme.TextPrimary;
        }
    }
}
