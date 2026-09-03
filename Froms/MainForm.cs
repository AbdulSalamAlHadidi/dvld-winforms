using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Desktop.Navigation;
using DVLD.Desktop.Pages.Dashboard;

namespace DVLD.Desktop.Froms
{
    public partial class MainForm : Form
    {
        private NavigationService _navigationService;
        private Button _activeButton;
        private static readonly Color _defaultBackColor = Color.FromArgb(33, 33, 33);
        private static readonly Color _defaultForeColor = Color.FromArgb(161, 161, 170);
        private static readonly Color _activeBackColor = Color.FromArgb(109, 40, 217);
        private static readonly Color _activeForeColor = Color.FromArgb(249, 250, 251);
        public MainForm()
        {
            InitializeComponent();

            _navigationService = new NavigationService(pnlContent);
            _navigationService.NavigateTo(new DashboardControl());
            lblPageTitle.Text = "Dashboard";
        }

        private void NavigateAndHighlight(Button clickedButton, UserControl page, string title)
        {
            _navigationService.NavigateTo(page);
            lblPageTitle.Text = title;

            if(_activeButton != null)
            {
                _activeButton.BackColor = _defaultBackColor;
                _activeButton.ForeColor = _defaultForeColor;
            }

            clickedButton.BackColor = _activeBackColor;
            clickedButton.ForeColor = _activeForeColor;

            _activeButton = clickedButton;
        }

        private void btnNavDashboard_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavDashboard, new DashboardControl(), "Dashboard");
        }

        private void btnNavPeople_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavPeople, new UserControl(), "People page not implemented yet.");
        }

        private void btnNavDrivers_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavDrivers, new UserControl(), "Drivers page not implemented yet.");
        }

        private void btnNavApplications_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavApplications, new UserControl(), "Applications page not implemented yet.");
        }

        private void btnNavLicenses_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavLicenses, new UserControl(), "Licenses page not implemented yet.");
        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavUsers, new UserControl(), "Users page not implemented yet.");
        }

        private void btnNavSettings_Click(object sender, EventArgs e)
        {
            NavigateAndHighlight(btnNavSettings, new UserControl(), "Settings page not implemented yet.");
        }
    }
}
