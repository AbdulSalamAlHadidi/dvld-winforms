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
        public MainForm()
        {
            InitializeComponent();

            _navigationService = new NavigationService(pnlContent);
            _navigationService.NavigateTo(new DashboardControl());
            lblPageTitle.Text = "Dashboard";
        }
    }
}
