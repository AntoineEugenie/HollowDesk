using Microsoft.Maui.Storage;
using System;

namespace HollowDesk.Services
{
    public class ThemeService
    {
        public string ThemeClass { get; private set; } = "theme-green";
        public bool ScanlinesActive { get; private set; } = true;

      
        public event Action? OnThemeChanged;

        public ThemeService()
        {
            MettreAJourLocalement();
        }

      
        public void MettreAJourLocalement()
        {
            string color = Preferences.Default.Get("ThemeColor", "green");
            ThemeClass = color switch
            {
                "orange" => "theme-orange",
                "green" => "theme-green",
                _ => ""
            };
            ScanlinesActive = Preferences.Default.Get("ScanlinesEnabled", true);

           
            OnThemeChanged?.Invoke();
        }
    }
}