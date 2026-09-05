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
using DVLD.Desktop.Controls;

namespace DVLD.Desktop.Froms
{
    public partial class MainForm : Form
    {
        private NavigationService _navigationService;
        private NavButton _activeNavButton;

        public MainForm()
        {
            InitializeComponent();

            BuildSidebarNavigation();
            _navigationService = new NavigationService(pnlContent);
            NavigateAndHighlight(navDashboard, new DashboardControl(), "Dashboard");
        }
        private NavButton navDashboard;
        private NavButton navPeople;
        private NavButton navDrivers;
        private NavButton navApplications;
        private NavButton navLicenses;
        private NavButton navUsers;
        private NavButton navSettings;

        private void BuildSidebarNavigation()
        {
            navDashboard = CreateNavButton("Dashboard");
            navPeople = CreateNavButton("People");
            navDrivers = CreateNavButton("Drivers");
            navApplications = CreateNavButton("Applications");
            navLicenses = CreateNavButton("Licenses");
            navUsers = CreateNavButton("Users");
            navSettings = CreateNavButton("Settings");

            navDashboard.NavClicked += (s, e) => NavigateAndHighlight(navDashboard, new DashboardControl(), "Dashboard");
            navPeople.NavClicked += (s, e) => NavigateAndHighlight(navPeople, new UserControl(), "People");
            //navPeople.NavClicked += (s, e) => MessageBox.Show("People page not implemented yet.");
            navDrivers.NavClicked += (s, e) => MessageBox.Show("Drivers page not implemented yet.");
            navApplications.NavClicked += (s, e) => MessageBox.Show("Applications page not implemented yet.");
            navLicenses.NavClicked += (s, e) => MessageBox.Show("Licenses page not implemented yet.");
            navUsers.NavClicked += (s, e) => MessageBox.Show("Users page not implemented yet.");
            navSettings.NavClicked += (s, e) => MessageBox.Show("Settings page not implemented yet.");

            pnlSidebar.Controls.Add(navSettings);
            pnlSidebar.Controls.Add(navUsers);
            pnlSidebar.Controls.Add(navLicenses);
            pnlSidebar.Controls.Add(navApplications);
            pnlSidebar.Controls.Add(navDrivers);
            pnlSidebar.Controls.Add(navPeople);
            pnlSidebar.Controls.Add(navDashboard);
            pnlSidebar.Controls.Add(lblDVLD);
        }

        private NavButton CreateNavButton(string text)
        {
            var navButton = new NavButton
            {            
                NavText = text,
                Dock = DockStyle.Top
            };

            return navButton;
        }

        private void NavigateAndHighlight(NavButton clickedButton, UserControl page, string title)
        {
            _navigationService.NavigateTo(page);
            lblPageTitle.Text = title;

            if (_activeNavButton != null)
                _activeNavButton.IsActive = false;

            clickedButton.IsActive = true;
            _activeNavButton = clickedButton;
        }
    }
}
