using NEA_JacobRussell_Application.Views;

namespace NEA_JacobRussell_Application
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Rhythms), typeof(Rhythms));
            Routing.RegisterRoute(nameof(Notes), typeof(Notes));
            Routing.RegisterRoute(nameof(Intervals), typeof(Intervals));
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        }
    }
}