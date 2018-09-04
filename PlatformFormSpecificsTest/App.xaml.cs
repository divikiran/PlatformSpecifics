using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PlatformFormSpecificsTest
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();

            Xamarin.Forms.NavigationPage navigationPage = new Xamarin.Forms.NavigationPage(new HomeMasterListPage());
            //navigationPage.On<iOS>().SetPrefersLargeTitles(true);
            //navigationPage.BackgroundColor = Color.Red;
            //navigationPage.On<iOS>().EnableTranslucentNavigationBar();
            MainPage = navigationPage;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
