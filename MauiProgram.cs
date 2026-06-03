using H.NotifyIcon;
using Microsoft.Extensions.Logging;

namespace HollowDesk
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseNotifyIcon()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            var supabaseUrl = "https://jrmsodsbonegbbfnmgit.supabase.co";
            var supabaseKey = "sb_publishable_vRGjdd8qd8umP_52K5HvKQ_WYvALUsG";
            var options = new Supabase.SupabaseOptions
            {
                AutoConnectRealtime = true,
                AutoRefreshToken = true,
            };


            builder.Services.AddSingleton(provider => new Supabase.Client(supabaseUrl, supabaseKey, options));
            builder.Services.AddSingleton<HollowDesk.Services.ThemeService>();
            builder.UseNotifyIcon();
            return builder.Build();
        }
    }
}
