using DVLD.Desktop.Controls;
using DVLD.Desktop.Navigation;
using DVLD.Desktop.Theme;
using System.Windows.Forms;

namespace DVLD.Desktop.Pages.People
{
    public partial class PersonDetailsControl : UserControl
    {
        public NavigationService Navigation { get; set; }
        private readonly PersonRow _person;
        public PersonDetailsControl(PersonRow person)
        {
            InitializeComponent();

            _person = person;

            pageHeader.ActionClicked += (s, e) => MessageBox.Show("Edit Person form not implemented yet.");

            pageHeader.BackClicked += (s, e) => Navigation?.GoBack();

            BuildCards();

            ApplyTheme();
        }

        private void BuildCards()
        {
            // بطاقة المعلومات الشخصية
            var personalCard = new DetailsCard
            {
                CardTitle = "Personal Information"
            };
            personalCard.AddRow("Full Name", _person.FullName);
            personalCard.AddRow("National Number", _person.NationalNumber);
            personalCard.AddRow("Date of Birth", _person.DateOfBirth);
            personalCard.AddRow("Gender", _person.Gender);

            // بطاقة معلومات الاتصال
            var contactCard = new DetailsCard
            {
                CardTitle = "Contact Information"
            };
            contactCard.AddRow("Phone", _person.Phone);
            contactCard.AddRow("Status", _person.Status);

            // بطاقة معلومات النظام
            var systemCard = new DetailsCard
            {
                CardTitle = "System Information"
            };
            systemCard.AddRow("Person ID", _person.Id.ToString());


            // إضافة البطاقات إلى الـ FlowLayoutPanel
            flowCards.Controls.Add(personalCard);
            flowCards.Controls.Add(contactCard);
            flowCards.Controls.Add(systemCard);
        }

        private void ApplyTheme()
        {
            var theme = ThemeManager.Current;
            
            BackColor = theme.Background;
        }
    }
}