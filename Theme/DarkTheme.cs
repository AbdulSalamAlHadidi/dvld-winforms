using System.Drawing;

namespace DVLD.Desktop.Theme
{
    public static class DarkTheme
    {
        public static AppTheme Instance { get; } = new AppTheme
        {
            Background = Color.FromArgb(18, 18, 18),     
            Sidebar = Color.FromArgb(33, 33, 33),     
            Surface = Color.FromArgb(31, 41, 55),     
            InputBackground = Color.FromArgb(37, 42, 52),     
            Border = Color.FromArgb(55, 65, 81),     

            HoverBackground = Color.FromArgb(39, 39, 42),

            Primary = Color.FromArgb(109, 40, 217),   
            PrimaryHover = Color.FromArgb(124, 58, 237),  

            TextPrimary = Color.FromArgb(249, 250, 251),  
            TextSecondary = Color.FromArgb(161, 161, 170),  

            Success = Color.FromArgb(34, 197, 94),   
            Warning = Color.FromArgb(245, 158, 11),  
            Danger = Color.FromArgb(239, 68, 68),    

            Accent = Color.FromArgb(255,0,0), // side panel color

        };
    }
}