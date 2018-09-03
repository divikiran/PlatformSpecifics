using System;
using System.Collections.Generic;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms;

namespace PlatformFormSpecificsTest
{
    public partial class ListViewSeperatorPage : ContentPage
    {
        public ListViewSeperatorPage()
        {
            InitializeComponent();
            listView.On<iOS>().SetSeparatorStyle(SeparatorStyle.FullWidth);
        }
    }
}
