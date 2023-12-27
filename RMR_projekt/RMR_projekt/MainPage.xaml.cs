namespace RMR_projekt
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void Register_Clicked(object sender, EventArgs e)
        {

           await Navigation.PushAsync(new RegisterPage());

        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }



        /*  private void OnCounterClicked(object sender, EventArgs e)
          {
              count++;

              if (count == 1)
                  CounterBtn.Text = $"Clicked {count} time";
              else
                  CounterBtn.Text = $"Clicked {count} times";

              SemanticScreenReader.Announce(CounterBtn.Text);
          }*/
    }

}
