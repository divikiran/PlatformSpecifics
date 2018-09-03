using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific.AppCompat;

namespace PlatformFormSpecificsTest
{
    public class PageViewModel : INotifyPropertyChanged
    {
        string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        bool buttonClicked;

        public bool ButtonClicked
        {
            get
            {
                return buttonClicked;
            }

            set
            {
                buttonClicked = value;
                OnPropertyChanged("ButtonClicked");
            }
        }
        bool isEnabled;

        public bool IsEnabled
        {
            get
            {
                return isEnabled;
            }

            set
            {
                isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
    public partial class PageLifeCyclePage : ContentPage
    {
        public PageViewModel VM
        {
            get;
            set;
        }
        public PageLifeCyclePage()
        {
            InitializeComponent();
            BindingContext = VM = new PageViewModel();
            VM.Name = "Enable";
        }

        public bool ButtonClicked
        {
            get;
            set;
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            ButtonClicked = !ButtonClicked;
            VM.Name = ButtonClicked ? "Disabled" : "Enabled";
            Xamarin.Forms.Application.Current.On<Android>()
             .UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize)
                   .SendDisappearingEventOnPause(ButtonClicked)
                   .SendAppearingEventOnResume(ButtonClicked)
                   .ShouldPreserveKeyboardOnResume(true);
        }


    }
}
