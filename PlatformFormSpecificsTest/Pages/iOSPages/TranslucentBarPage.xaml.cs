using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class TranslucentBarPage : Xamarin.Forms.NavigationPage
    {
        public TranslucentBarPage()
        {
            InitializeComponent();



            ////(App.Current.MainPage.Navigation.NavigationStack.Last() as Xamarin.Forms.NavigationPage)
            ////.On<iOS>()
            ////.SetIsNavigationBarTranslucent(!(App.Current.MainPage.Navigation.NavigationStack.Last() as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());
            //var a = (Xamarin.Forms.MasterDetailPage)App.Current.MainPage;
            //Xamarin.Forms.Page detailPage = a.Detail;
            //if (detailPage is Xamarin.Forms.NavigationPage)
            //{
            //    // detailPage.BackgroundColor = Color.Red;
            //    //detailPage.On<iOS>().EnableTranslucentNavigationBar();
            //    //((Xamarin.Forms.NavigationPage)detailPage).On<iOS>().SetIsNavigationBarTranslucent(!(detailPage as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());

            //    ((Xamarin.Forms.NavigationPage)detailPage).On<iOS>().SetIsNavigationBarTranslucent(!(detailPage as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());
            //    //(App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(!(App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().IsNavigationBarTranslucent());
            //}
        }

        //void Handle_Clicked(object sender, System.EventArgs e)
        //{
            
        //    if (App.Current.MainPage is Xamarin.Forms.NavigationPage)
        //    {
        //        (App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(true);
        //    }

        //}

    }
}
