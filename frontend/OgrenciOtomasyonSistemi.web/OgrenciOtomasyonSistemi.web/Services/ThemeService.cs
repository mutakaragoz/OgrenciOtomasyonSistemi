namespace OgrenciOtomasyonSistemi.web.Services
{
    public class ThemeService
    {
        public bool IsDarkMode { get; private set; }
        public event Action OnChange;

        public void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
