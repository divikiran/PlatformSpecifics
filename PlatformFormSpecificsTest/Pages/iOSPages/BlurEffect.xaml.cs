using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class BlurEffect : ContentPage
    {
        public BlurEffect()
        {
            InitializeComponent();

            //box1.On<iOS>().UseBlurEffect(BlurEffectStyle.ExtraLight);
            //box2.On<iOS>().UseBlurEffect(BlurEffectStyle.Dark);
            //box3.On<iOS>().UseBlurEffect(BlurEffectStyle.Light);
        }
    }
}
