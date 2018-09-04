using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;


namespace PlatformFormSpecificsTest
{
    public partial class HomeMasterListPage : ContentPage
    {
        public HomeMasterListPage()
        {
            InitializeComponent();

            listviewitems.ItemSelected += OnItemSelected;
        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is MasterPageItem item)
            {
                var page = (Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType);
                //var nav = new Xamarin.Forms.NavigationPage(page);
                //nav.On<iOS>().EnableTranslucentNavigationBar();
                //nav.On<iOS>().SetPrefersLargeTitles(true);

                App.Current.MainPage.Navigation.PushAsync(page);

                listviewitems.SelectedItem = null;

            }
        }
    }
}
