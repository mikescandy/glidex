using System.Linq;
using Xamarin.Forms;

namespace Android.Glide.Sample
{
	public partial class FlexLayoutPage
    {
		public FlexLayoutPage()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindableLayout.SetItemsSource(F, Images.RandomSources());
        }
    }
}