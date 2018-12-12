using Xamarin.Forms;

namespace Android.Glide.Sample
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // Navigate to flexlayoutpage to see that performance is ok
            MainPage = new NavigationPage(new MainPage());
            //MainPage = new FlexLayoutPage();
        }
	}
}
