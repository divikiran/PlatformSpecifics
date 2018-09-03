using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class BottomTabbedPage : Xamarin.Forms.TabbedPage
    {
        public BottomTabbedPage()
        {
            InitializeComponent();

            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom)
                         .SetBarItemColor(Xamarin.Forms.Color.Black)
                         .SetBarSelectedItemColor(Xamarin.Forms.Color.Red);
        }
    }
}
