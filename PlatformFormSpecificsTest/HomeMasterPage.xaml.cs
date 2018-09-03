using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class HomeMasterPage : MasterDetailPage
    {
        public HomeMasterPage()
        {
            InitializeComponent();

            masterPage.listviewitems.ItemSelected += OnItemSelected;

            if (Device.RuntimePlatform == Device.UWP)
            {
                MasterBehavior = MasterBehavior.Popover;
            }

            //IsPresentedChanged += HomeMasterPage_IsPresentedChanged;

        }

        void HomeMasterPage_IsPresentedChanged(object sender, EventArgs e)
        {
            var mdp = sender as MasterDetailPage;
            if (mdp.IsPresented)
                ((Xamarin.Forms.NavigationPage)mdp.Detail)
                  .On<iOS>()
                  .SetStatusBarTextColorMode(StatusBarTextColorMode.DoNotAdjust);
            else
                ((Xamarin.Forms.NavigationPage)mdp.Detail)
                  .On<iOS>()
                  .SetStatusBarTextColorMode(StatusBarTextColorMode.MatchNavigationBarTextLuminosity);

        }


        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                var page = (Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType);
                //page.On<iOS>().EnableTranslucentNavigationBar();
                //page.On<iOS>().SetPrefersLargeTitles(true);

                if(page is TranslucentPage)
                {
                    Detail = new Xamarin.Forms.NavigationPage(page);
                }
                else
                {
                    Detail = page;    
                }

                masterPage.listviewitems.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
