using System;

namespace DVLD.Desktop.Theme
{
    public static class ThemeManager
    {
        private static AppTheme _current = DarkTheme.Instance;

        public static AppTheme Current => _current;

        public static event EventHandler ThemeChanged;

        public static void SetTheme(AppTheme theme)
        {
            _current = theme;
            ThemeChanged?.Invoke(null, EventArgs.Empty);
        }
    }
}