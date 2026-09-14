using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DVLD.Desktop.Navigation
{
    public class NavigationService
    {
        private readonly Panel _contentPanel;
        private readonly Stack<UserControl> _history = new Stack<UserControl>();
        private UserControl _current;

        public event EventHandler CanGoBackChanged;

        public NavigationService(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            _contentPanel.Dock = DockStyle.Fill;
        }

        public bool CanGoBack => _history.Count > 0;

        public void NavigateTo(UserControl page)
        {
            if (_current != null)
                _history.Push(_current);

            Show(page);
            RaiseCanGoBackChanged();
        }

        public void ResetTo(UserControl page)
        {
            _history.Clear();
            Show(page);
            RaiseCanGoBackChanged();
        }

        public void GoBack()
        {
            if (!CanGoBack) return;
            Show(_history.Pop());
            RaiseCanGoBackChanged();
        }

        private void Show(UserControl page)
        {
            _contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            _contentPanel.Controls.Add(page);
            _current = page;
        }

        private void RaiseCanGoBackChanged()
            => CanGoBackChanged?.Invoke(this, EventArgs.Empty);
    }
}