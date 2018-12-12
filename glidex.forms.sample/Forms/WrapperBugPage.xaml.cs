using Xamarin.Forms;

namespace Android.Glide.Sample
{
	public partial class WrapperBugPage
    {
		public WrapperBugPage()
		{
			InitializeComponent ();
            BindableLayout.SetItemsSource(S, Images.RandomSources());
        }

         
    }
}