using HollowDesk;

namespace HollowDesk
{
    public partial class App : Application
    {
        private readonly Supabase.Client _supabase;

        public App(Supabase.Client supabase)
        {
            InitializeComponent();
            _supabase = supabase;
            _supabase.Auth.AddStateChangedListener((sender, state) =>
            {
                if (_supabase.Auth.CurrentSession != null)
                    Preferences.Default.Set("supabase_session",
                        System.Text.Json.JsonSerializer.Serialize(_supabase.Auth.CurrentSession));
                else
                    Preferences.Default.Remove("supabase_session");
            });
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            RestoreSession();
            return new Window(new MainPage()) { Title = "HollowDesk" };
        }

        private async void RestoreSession()
        {
            var savedSession = Preferences.Default.Get("supabase_session", string.Empty);
            if (!string.IsNullOrEmpty(savedSession))
            {
                try
                {
                    var session = System.Text.Json.JsonSerializer
                        .Deserialize<Supabase.Gotrue.Session>(savedSession);
                    if (session != null)
                        await _supabase.Auth.SetSession(session.AccessToken, session.RefreshToken);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Session restore error: {ex.Message}");
                    Preferences.Default.Remove("supabase_session");
                }
            }
        }
    }



}