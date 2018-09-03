using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PlatformFormSpecificsTest.ViewModels
{
    public class ListViewModel : INotifyPropertyChanged
    {
        public ListViewModel()
        {
            Numbers = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                Numbers.Add(i);
            }

        }
        List<int> numbers;

        public List<int> Numbers
        {
            get
            {
                return numbers;
            }

            set
            {
                numbers = value;
                OnPropertyChanged("Numbers");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
