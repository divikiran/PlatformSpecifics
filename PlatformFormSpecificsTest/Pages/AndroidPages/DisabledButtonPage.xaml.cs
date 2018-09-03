using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PlatformFormSpecificsTest
{
    public partial class DisabledButtonPage : ContentPage
    {

        public PageViewModel VM
        {
            get;
            set;
        }

        public DisabledButtonPage()
        {
            InitializeComponent();
            BindingContext = VM = new PageViewModel();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            VM.IsEnabled = !VM.IsEnabled;
        }
    }
}
