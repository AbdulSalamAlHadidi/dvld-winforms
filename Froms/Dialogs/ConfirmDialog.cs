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

            btnConfirm.BackColor = Color.FromArgb(239, 68, 68);
            btnConfirm.ForeColor = Color.FromArgb(249, 250, 251);
            btnCancel.BackColor = Color.FromArgb(55, 65, 81);
            btnCancel.ForeColor = Color.FromArgb(249, 250, 251);

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
    }
}
