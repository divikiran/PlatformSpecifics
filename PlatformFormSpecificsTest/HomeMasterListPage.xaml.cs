using System;
using System.Collections.Generic;

using Xamarin.Forms;

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
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                var page = (Xamarin.Forms.Page)Activator.CreateInstance(item.TargetType);
                //page.On<iOS>().EnableTranslucentNavigationBar();
                //page.On<iOS>().SetPrefersLargeTitles(true);

                App.Current.MainPage.Navigation.PushAsync(page);

                listviewitems.SelectedItem = null;

            }
        }
    }
}
