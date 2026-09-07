using System.Drawing;

namespace DVLD.Desktop.Theme
{
    public class AppTheme
    {
        // خلفيات عامة
        public Color Background { get; set; }
        public Color Sidebar { get; set; }
        public Color Surface { get; set; }      // بطاقات، Topbar
        public Color InputBackground { get; set; }
        public Color Border { get; set; }

        // حالات التفاعل (مستخرجة من NavButton سابقًا)
        public Color HoverBackground { get; set; }

        // الألوان الأساسية
        public Color Primary { get; set; }
        public Color PrimaryHover { get; set; }

        // النصوص
        public Color TextPrimary { get; set; }
        public Color TextSecondary { get; set; }

        // ألوان الحالة
        public Color Success { get; set; }
        public Color Warning { get; set; }
        public Color Danger { get; set; }

        // ... الخصائص الحالية ...
        public Color Accent { get; set; }   // لون الشريط الجانبي للعنصر النشط
    }
}