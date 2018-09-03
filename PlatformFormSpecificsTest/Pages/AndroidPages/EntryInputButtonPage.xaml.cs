using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class EntryInputButtonPage : ContentPage
    {
        public EntryInputButtonPage()
        {
            InitializeComponent();

            //eSend.On<Android>().SetImeOptions(ImeFlags.Search);
        }
    }
}
