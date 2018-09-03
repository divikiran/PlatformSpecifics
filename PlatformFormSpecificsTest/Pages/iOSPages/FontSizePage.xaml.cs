using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public partial class FontSizePage : ContentPage
    {
        public FontSizePage()
        {
            InitializeComponent();
            entryControl.BackgroundColor = Color.LightGray;
            //entryControl.Text = "You can spell check very long text areas without compromising any performance hits. Regardless of the size of the text, UltimateSpell only sends small portions of the text to the server as needed, while the user spell checks through the text.... You can spell check very long text areas without compromising any performance hits. Regardless of the size of the text, UltimateSpell only sends small portions of the text to the server as needed, while the user spell checks through the text123123123";
            entryControl.On<iOS>().EnableAdjustsFontSizeToFitWidth();
        }
    }
}
