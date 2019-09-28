using System;

namespace blazor_dynamic_themes_sample
{
    internal class AppState
    {
        public string ActiveTheme { get; private set; } = "Default";

        public event Action OnChange;

        public void SetTheme(string name)
        {
            ActiveTheme = name;

            NotifyStateChanged();
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
