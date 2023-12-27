namespace RMR_projekt;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
       // LoadCharts();
    }

    private async void Save_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TreningPage());
    }
}