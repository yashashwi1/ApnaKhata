using ApnaKhata.DataModels;
using ApnaPOC.Services;

namespace ApnaPOC;

public partial class MainPage : ContentPage
{
	public Dictionary<string, object?>? parameters = new Dictionary<string, object?>();
    public User User { get; set; }

    private readonly IServiceProvider provider;
	public MainPage( IServiceProvider provider)
	{
		InitializeComponent();
        this.provider = provider;
       // MauiAppBuilder.
    }

    

    public async Task<User> LoadUserData(User user)
    {
        var serviceLocator = provider.GetService(typeof(ServiceLocator));
        
        UserService userService = (UserService)provider.GetService(typeof(UserService));
        var x = await userService.GetUserDetails("as");

        parameters.Add("userData", x);
        blazorWebView.BindingContext = this;
        rootComponent.Parameters = parameters;
        this.BindingContext = this;
        return x;
    }
    
}
