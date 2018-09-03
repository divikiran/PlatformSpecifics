using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class StatusBarPage2 : ContentPage
    {
        public StatusBarPage2()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var d = On<iOS>().PrefersStatusBarHidden();
            if (d == StatusBarHiddenMode.True)
            {
                On<iOS>().SetPrefersStatusBarHidden(StatusBarHiddenMode.False);
            }
            else
            {
                On<iOS>().SetPrefersStatusBarHidden(StatusBarHiddenMode.True);
            }
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            var a = On<iOS>().PreferredStatusBarUpdateAnimation();
            if (a == UIStatusBarAnimation.Slide)
            {
                On<iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.Fade);
            }
            else
            {
                On<iOS>().SetPreferredStatusBarUpdateAnimation(UIStatusBarAnimation.Slide);
            }

        }
    }
}
