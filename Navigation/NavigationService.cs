using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Desktop.Navigation
{
    internal class NavigationService
    {
        private readonly Panel _contentPanel;

        public NavigationService(Panel contentPanel)
        {
            _contentPanel = contentPanel;
            _contentPanel.Dock = DockStyle.Fill;
        }

        public void NavigateTo(UserControl page)
        {
            _contentPanel.Controls.Clear();
            page.Dock = DockStyle.Fill;
            _contentPanel.Controls.Add(page);
        }


    }
}
