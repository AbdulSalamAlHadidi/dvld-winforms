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
using DVLD.Desktop.Theme;

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

            ApplyTheme();

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
            dgvPeople.EnableHeadersVisualStyles = false;

            //Column Header Formatting
            dgvPeople.ColumnHeadersHeight = 40;

            //Cell Formatting
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

                        if(currentList.Remove(person))
                        MessageBox.Show($"{person.FullName} deleted Successfully.");

                        LoadPeople(currentList); // إعادة تحميل القائمة المحدثة
                    }
                    break;
            }
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;

            // خلفية التحكم الرئيسي
            BackColor = theme.Background;

            // إعدادات الجدول
            dgvPeople.BackgroundColor = theme.Background;
            dgvPeople.GridColor = theme.Border;

            // رأس الجدول
            dgvPeople.ColumnHeadersDefaultCellStyle.BackColor = theme.Surface;
            dgvPeople.ColumnHeadersDefaultCellStyle.ForeColor = theme.TextPrimary;
            dgvPeople.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f);

            // خلايا الجدول
            dgvPeople.DefaultCellStyle.BackColor = theme.Surface;
            dgvPeople.DefaultCellStyle.ForeColor = theme.TextPrimary;
            dgvPeople.DefaultCellStyle.SelectionBackColor = theme.Primary;
            dgvPeople.DefaultCellStyle.SelectionForeColor = theme.TextPrimary;

            // تحديث ألوان أزرار الأعمدة (إذا كانت موجودة)
            if (dgvPeople.Columns.Contains("colView"))
            {
                var colView = dgvPeople.Columns["colView"] as DataGridViewButtonColumn;
                colView.DefaultCellStyle.BackColor = theme.Border;
                colView.DefaultCellStyle.ForeColor = theme.TextPrimary;
            }
            if (dgvPeople.Columns.Contains("colEdit"))
            {
                var colEdit = dgvPeople.Columns["colEdit"] as DataGridViewButtonColumn;
                colEdit.DefaultCellStyle.BackColor = theme.Border;
                colEdit.DefaultCellStyle.ForeColor = theme.TextPrimary;
            }
            if (dgvPeople.Columns.Contains("colDelete"))
            {
                var colDelete = dgvPeople.Columns["colDelete"] as DataGridViewButtonColumn;
                colDelete.DefaultCellStyle.BackColor = theme.Danger;
                colDelete.DefaultCellStyle.ForeColor = theme.TextPrimary;
            }
        }

    }

}
