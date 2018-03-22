using MultiLanguage.Resources;
using Plugin.Multilingual;

using Xamarin.Forms;

namespace MultiLanguage
{
	public partial class App : Application
	{
		public App ()
		{
            //CrossMultilingual.Current.CurrentCultureInfo = CrossMultilingual.Current.DeviceCultureInfo;
            CrossMultilingual.Current.CurrentCultureInfo = new System.Globalization.CultureInfo("pt");
            AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;

            InitializeComponent();
            MainPage = new MultiLanguage.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
