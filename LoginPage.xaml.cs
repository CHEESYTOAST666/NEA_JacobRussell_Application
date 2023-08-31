using NEA_JacobRussell_Application.Resources.ViewModels;

namespace NEA_JacobRussell_Application;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
        this.BindingContext = viewModel;
	}

    private async void BtnLoginClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}