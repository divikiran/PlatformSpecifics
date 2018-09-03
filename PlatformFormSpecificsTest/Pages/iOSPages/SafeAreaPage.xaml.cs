using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PlatformFormSpecificsTest
{
    public partial class SafeAreaPage : ContentPage
    {
        public SafeAreaPage()
        {
            InitializeComponent();
            longText.Text = "This platform-specific is used to ensure that page content is positioned on an area of the screen that is safe for all devices that use iOS 11 and greater. Specifically, it will help to make sure that content isn't clipped by rounded device corners, the home indicator, or the sensor housing on an iPhone X. It's consumed in XAML by setting the Page.UseSafeArea attached property to a boolean value:This platform-specific is used to ensure that page content is positioned on an area of the screen that is safe for all devices that use iOS 11 and greater. Specifically, it will help to make sure that content isn't clipped by rounded device corners, the home indicator, or the sensor housing on an iPhone X. It's consumed in XAML by setting the Page.UseSafeArea attached property to a boolean value:";
        }
    }
}
