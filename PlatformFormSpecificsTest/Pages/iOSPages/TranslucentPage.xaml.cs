using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class TranslucentPage : ContentPage
    {
        public TranslucentPage()
        {
            InitializeComponent();
            button.Text = "Translucent On";
        }

        public bool Toggled
        {
            get;
            set;
        } = true;
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (Toggled)
            {
                if (App.Current.MainPage is Xamarin.Forms.NavigationPage)
                {
                    (App.Current.MainPage as Xamarin.Forms.NavigationPage).BackgroundColor = Color.Blue;
                    (App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(true);
                }
            }
            else
            {
                if (App.Current.MainPage is Xamarin.Forms.NavigationPage)
                {
                    (App.Current.MainPage as Xamarin.Forms.NavigationPage).BackgroundColor = Color.White;
                    (App.Current.MainPage as Xamarin.Forms.NavigationPage).On<iOS>().SetIsNavigationBarTranslucent(false);
                }
            }
            Toggled = !Toggled; 
            button.Text = "Translucent " + (Toggled ? "On" : "Off");
        }
    }
}
