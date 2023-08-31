using Microsoft.Maui.Controls;
using NEA_JacobRussell_Application.Views;

namespace NEA_JacobRussell_Application
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            BackgroundColor = Colors.AntiqueWhite;
        }


        private async void BtnNotes_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Notes());
        }

        private async void BtnRhythm_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Rhythms());
        }

        private async void BtnIntervals_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Intervals());
        }

        private async void BtnLogout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());

        }
    }
}