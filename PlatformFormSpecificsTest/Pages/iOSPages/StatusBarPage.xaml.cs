using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PlatformFormSpecificsTest
{
    public partial class StatusBarPage : ContentPage
    {
        public StatusBarPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new StatusBarPage2());
        }
    }
}
