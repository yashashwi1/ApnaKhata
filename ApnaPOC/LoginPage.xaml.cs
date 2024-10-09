using ApnaKhata.DataModels;

namespace ApnaPOC;

public partial class LoginPage : ContentPage
{
    private readonly IServiceProvider provider;
	public LoginPage(IServiceProvider provider)
	{
        this.provider = provider;
		InitializeComponent();
	}

	private async void Login_Clicked(object sender, EventArgs e)
	{
        User user = new User();
        user.FirstName = "ABCD";
        user.LastLogin = "Sriv";
        user.LastLogin = "NOW";
        user.LastUpdated = "OLD";
        var mainPage = new MainPage(this.provider);
        mainPage.User = user;
        await mainPage.LoadUserData(user);
        await App.Current.MainPage.Navigation.PushModalAsync(mainPage);
        //await Navigation.PushAsync();
	}

    private async void RegisterMe_Clicked(object sender, EventArgs e)
    {
      
        //await Navigation.PushAsync();
    }
}