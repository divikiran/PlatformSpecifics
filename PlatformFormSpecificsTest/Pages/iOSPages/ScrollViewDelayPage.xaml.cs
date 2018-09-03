using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class ScrollViewDelayPage : ContentPage
    {
        public ScrollViewDelayPage()
        {
            InitializeComponent();
            scrollView.On<iOS>().SetShouldDelayContentTouches(true);
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            bool a = scrollView.On<iOS>().ShouldDelayContentTouches();

            scrollView.On<iOS>().SetShouldDelayContentTouches(!a);
            //throw new NotImplementedException();
        }
    }
}
