using System;
using System.Collections.Generic;
using PlatformFormSpecificsTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class ListViewFastScrollPage : ContentPage
    {
        public ListViewFastScrollPage()
        {
            InitializeComponent();
            BindingContext = new ListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            listview.On<Android>().SetIsFastScrollEnabled(!listview.On<Android>().IsFastScrollEnabled());
        }
    }
}
