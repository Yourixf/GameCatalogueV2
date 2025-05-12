namespace GameCatalogueV2.Services;


public class ThemeService {
    public string CurrentTheme {get; private set;} = "dark-mode";

    public event Action? OnChange;

    public void ToggleTheme() {
        CurrentTheme = CurrentTheme == "dark-mode" ? "light-mode" : "dark-mode";
        OnChange?.Invoke();
    }
}