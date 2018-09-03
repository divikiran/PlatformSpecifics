using System;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace PlatformFormSpecificsTest
{
    public class BlankPage : ContentPage
    {


        public PageViewModel VM
        {
            get;
            set;
        }

        public BlankPage()
        {
            On<iOS>().SetLargeTitleDisplay(LargeTitleDisplayMode.Never);
            Title = "Platform Specifics";

            BindingContext = VM = new PageViewModel();
            VM.Name = "Enable";

            var button = new Xamarin.Forms.Button();
            button.SetBinding(Xamarin.Forms.Button.TextProperty,"Name");


            button.Clicked += Button_Clicked;
            Content = new StackLayout
            {
                HorizontalOptions=LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    new Label { Text = "Xamarin Forms Platform Specifics" },
                    new Xamarin.Forms.Entry { Text = "Test" },
                    button
                }
            };
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            VM.ButtonClicked = !VM.ButtonClicked;
            VM.Name = VM.ButtonClicked ? "Disabled" : "Enabled";
            Xamarin.Forms.Application.Current.On<Android>()
             .UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize)
                   .SendDisappearingEventOnPause(VM.ButtonClicked)
                   .SendAppearingEventOnResume(VM.ButtonClicked)
                   .ShouldPreserveKeyboardOnResume(true);
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}

