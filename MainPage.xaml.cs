using H.NotifyIcon;
using CommunityToolkit.Mvvm.Input;

namespace HollowDesk
{
    public partial class MainPage
    {
        private bool IsWindowVisible { get; set; } = true;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;
            //CanvasView.PaintSurface += CanvasViewOnPaintSurface;
        }

        [RelayCommand]
        public void ShowHideWindow()
        {
            var window = Application.Current?.Windows[0];
            if (window == null)
            {
                return;
            }

            if (IsWindowVisible)
            {
                window.Hide();
            }
            else
            {
                window.Show();
            }
            IsWindowVisible = !IsWindowVisible;
        }

        [RelayCommand]
        public void ExitApplication()
        {
            Application.Current?.Quit();
        }

    }
}
