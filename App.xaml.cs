namespace NEA_JacobRussell_Application
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navPage = new NavigationPage(new LoginPage());
            MainPage = navPage;
        }
    }
} 