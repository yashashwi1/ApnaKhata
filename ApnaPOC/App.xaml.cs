using ApnaPOC.Services;

namespace ApnaPOC;

public partial class App : Application
{
	public App(IServiceProvider provider)
	{
		provider.GetService(typeof(ServiceLocator));
		InitializeComponent();	
		MainPage = new LoginPage( provider);
		
	}
}
