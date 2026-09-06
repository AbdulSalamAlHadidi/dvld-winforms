using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD.Desktop.Pages.People
{
    // نموذج عرض بسيط خاص بالـ UI فقط، وليس Entity من طبقة الأعمال.
    // لاحقًا سيُستبدل بـ DTO حقيقي قادم من Business Layer.
    public class PersonRow
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string NationalNumber { get; set; }
        public string Gender { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
    }
}
