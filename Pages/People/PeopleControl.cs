using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Desktop.Pages.People
{
    public partial class PeopleControl : UserControl
    {
        public PeopleControl()
        {
            InitializeComponent();

            //no need as its inside navigation class, but need to test
            Dock = DockStyle.Fill;

            pageHeader.Title = "People";
            pageHeader.ActionText = "Add Person";
            pageHeader.ActionClicked += PageHeader_ActionClicked;

            filterBar.PlaceholderText = string.Empty;
            filterBar.SearchRequested += FilterBar_SearchRequested;

            ConfigurePeopleGrid();

            LoadPeople(MockPeopleData.GetSample());
        }

        private void ConfigurePeopleGrid()
        {

            //General Settings
            dgvPeople.AutoGenerateColumns = false;
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.MultiSelect = false;
            dgvPeople.ReadOnly = true;
            dgvPeople.BorderStyle = BorderStyle.None;
            dgvPeople.BackgroundColor = Color.FromArgb(18,18,18);
            dgvPeople.GridColor = Color.FromArgb(55, 65, 81);
            dgvPeople.EnableHeadersVisualStyles = false;

            //Column Header Formatting
            dgvPeople.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvPeople.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(249, 250, 251);
            dgvPeople.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);
            dgvPeople.ColumnHeadersHeight = 40;

            //Cell Formatting
            dgvPeople.DefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvPeople.DefaultCellStyle.ForeColor = Color.FromArgb(249, 250, 251);
            dgvPeople.DefaultCellStyle.SelectionBackColor = Color.FromArgb(109, 40, 217);
            dgvPeople.DefaultCellStyle.SelectionForeColor = Color.FromArgb(249, 250, 251);
            dgvPeople.RowTemplate.Height = 42;

            //Manually add Columns
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", DataPropertyName = "Id", Width = 60 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Full Name", DataPropertyName = "FullName", Width = 220 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNational", HeaderText = "National No.", DataPropertyName = "NationalNumber", Width = 160 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGender", HeaderText = "Gender", DataPropertyName = "Gender", Width = 90 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDob", HeaderText = "Date of Birth", DataPropertyName = "DateOfBirth", Width = 120 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Phone", DataPropertyName = "Phone", Width = 130 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", DataPropertyName = "Status", Width = 100 });

        }

        // ===== Load Data =====
        private void LoadPeople(System.Collections.Generic.List<PersonRow> people)
        {
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = people;
        }

        // ===== Events =====
        private void FilterBar_SearchRequested(object sender, string searchText)
        {
            var all = MockPeopleData.GetSample();

            if(string.IsNullOrWhiteSpace(searchText))
            {
                LoadPeople(all);
                return;
            }

            var filtered = all.FindAll(p =>
                p.FullName.ToLower().Contains(searchText.ToLower()) ||
                p.NationalNumber.ToLower().Contains(searchText.ToLower()));

            LoadPeople(filtered);
        }

        private void PageHeader_ActionClicked(object sender, EventArgs e)
        {
            MessageBox.Show("Add Person form not implemented yet.");
        }
    }
}
