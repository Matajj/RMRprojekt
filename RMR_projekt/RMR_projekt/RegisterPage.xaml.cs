namespace RMR_projekt;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private async void Register_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TreningPage());
    }
}