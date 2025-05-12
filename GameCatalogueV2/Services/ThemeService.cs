namespace GameCatalogueV2.Services;


public class ThemeService {
    public string CurrentTheme {get; private set;} = "dark-mode";

    public event Action? OnChange;

    public void ToggleTheme() {
        Console.WriteLine("AANGEROEPEN");
        Console.WriteLine(CurrentTheme);
        CurrentTheme = CurrentTheme == "dark-mode" ? "light-mode" : "dark-mode";
        Console.WriteLine(CurrentTheme);

        OnChange?.Invoke();
    }
}