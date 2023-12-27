namespace RMR_projekt;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void Login_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TreningPage());
    }
}