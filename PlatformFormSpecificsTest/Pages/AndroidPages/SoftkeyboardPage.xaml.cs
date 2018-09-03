using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PlatformFormSpecificsTest
{
    public partial class SoftkeyboardPage : ContentPage
    {
        public SoftkeyboardPage()
        {
            InitializeComponent();

            Content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    new Label { Text = "Xamarin Forms Platform Specifics" },
                    new Xamarin.Forms.Entry { Text = "Test" },
                }
            };
        }
    }
}
