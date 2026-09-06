using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.Desktop.Froms.Dialogs;
using DVLD.Desktop.Navigation;

namespace DVLD.Desktop.Pages.People
{
    public partial class PeopleControl : UserControl
    {
        public NavigationService Navigation { get; set; }
        private List<PersonRow> _people;                   // <-- أضف هذا لتخزين البيانات

        public PeopleControl()
        {
            InitializeComponent();

            pageHeader.Title = "People";
            pageHeader.ActionText = "Add Person";
            pageHeader.ActionClicked += PageHeader_ActionClicked;

            filterBar.PlaceholderText = string.Empty;
            filterBar.SearchRequested += FilterBar_SearchRequested;

            ConfigurePeopleGrid();

            LoadPeople(MockPeopleData.GetSample());

            dgvPeople.CellContentClick += DgvPeople_CellContentClick;

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
            dgvPeople.BackgroundColor = Color.FromArgb(18, 18, 18);
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
            // إضافة الأعمدة الأساسية
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colId", HeaderText = "ID", DataPropertyName = "Id", Width = 60 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colName", HeaderText = "Full Name", DataPropertyName = "FullName", Width = 220 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colNational", HeaderText = "National No.", DataPropertyName = "NationalNumber", Width = 160 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colGender", HeaderText = "Gender", DataPropertyName = "Gender", Width = 90 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDob", HeaderText = "Date of Birth", DataPropertyName = "DateOfBirth", Width = 120 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colPhone", HeaderText = "Phone", DataPropertyName = "Phone", Width = 130 });
            dgvPeople.Columns.Add(new DataGridViewTextBoxColumn { Name = "colStatus", HeaderText = "Status", DataPropertyName = "Status", Width = 100 });

            // ---- Actions column (View, Edit, Delete) ----
            var colView = new DataGridViewButtonColumn { Name = "colView", HeaderText = "", Text = "View", UseColumnTextForButtonValue = true, Width = 70, FlatStyle = FlatStyle.Flat };
            var colEdit = new DataGridViewButtonColumn { Name = "colEdit", HeaderText = "", Text = "Edit", UseColumnTextForButtonValue = true, Width = 70, FlatStyle = FlatStyle.Flat };
            var colDelete = new DataGridViewButtonColumn { Name = "colDelete", HeaderText = "", Text = "Delete", UseColumnTextForButtonValue = true, Width = 70, FlatStyle = FlatStyle.Flat };

            colView.DefaultCellStyle.BackColor = Color.FromArgb(55, 65, 81);
            colEdit.DefaultCellStyle.BackColor = Color.FromArgb(55, 65, 81);
            colDelete.DefaultCellStyle.BackColor = Color.FromArgb(239, 68, 68);
            colView.DefaultCellStyle.ForeColor = colEdit.DefaultCellStyle.ForeColor = colDelete.DefaultCellStyle.ForeColor = Color.FromArgb(249, 250, 251);

            dgvPeople.Columns.Add(colView);
            dgvPeople.Columns.Add(colEdit);
            dgvPeople.Columns.Add(colDelete);

        }

        // ===== Load Data =====
        private void LoadPeople(System.Collections.Generic.List<PersonRow> people)
        {
            //new edit
            _people = people;
            dgvPeople.DataSource = null;
            dgvPeople.DataSource = people;
        }

        // ===== Events =====
        private void FilterBar_SearchRequested(object sender, string searchText)
        {
            var all = MockPeopleData.GetSample();

            if (string.IsNullOrWhiteSpace(searchText))
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

        // ---- معالج النقر على أزرار Actions داخل الجدول ----
        private void DgvPeople_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // التأكد من أن النقر على صف صحيح وليس على رأس الجدول
            if (e.RowIndex < 0) return;

            // استرجاع كائن الشخص المرتبط بالصف
            var person = (PersonRow)dgvPeople.Rows[e.RowIndex].DataBoundItem;
            if (person == null) return;

            // اسم العمود الذي تم النقر عليه
            var columnName = dgvPeople.Columns[e.ColumnIndex].Name;

            switch (columnName)
            {
                case "colView":
                    // فتح صفحة التفاصيل مع تمرير Navigation
                    var details = new PersonDetailsControl(person) { Navigation = Navigation };
                    Navigation?.NavigateTo(details);
                    break;

                case "colEdit":
                    MessageBox.Show("Edit Person form not implemented yet.");
                    break;

                case "colDelete":
                    // عرض ConfirmDialog
                    bool confirmed = ConfirmDialog.Confirm(
                        "Delete Person",
                        $"Are you sure you want to delete \"{person.FullName}\"?");

                    if (confirmed)
                    {
                        // حذف وهمي: إزالة من المصدر الحالي (القائمة المعروضة)
                        var currentList = (List<PersonRow>)dgvPeople.DataSource;
                        currentList.Remove(person);
                        LoadPeople(currentList); // إعادة تحميل القائمة المحدثة
                    }
                    break;
            }
        }
    }

}
