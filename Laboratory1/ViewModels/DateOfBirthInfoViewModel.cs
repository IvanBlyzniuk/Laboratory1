using Laboratory1.Models;
using System;
using Laboratory1.Tools;
using System.Windows;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Laboratory1.ViewModels
{
    
    internal class DateOfBirthInfoViewModel : INotifyPropertyChanged
    {
        private User user = new User();
        public event PropertyChangedEventHandler? PropertyChanged;

        private RelayCommand<object> acceptCommand;
        public RelayCommand<object> AcceptCommand
        {
            get
            {
                return acceptCommand ??= new RelayCommand<object>(o => Accept());
            }
        }

        public DateTime DateOfBirth { get => user.DateOfBirth; set => user.DateOfBirth = value;  }

        private string westernZodiac;
        public string WesternZodiac 
        { 
            get
            {
                return westernZodiac;
            }
            set
            {
                westernZodiac = value;
                OnPropertyChanged();
            }
        }
        private string chineseZodiac;
        public string ChineseZodiac
        { 
            get
            {
                return chineseZodiac;
            }
            set
            {
                chineseZodiac = value;
                OnPropertyChanged();
            }
        }

        private string ageMessage;
        public string AgeMessage
        { 
            get
            {
                return ageMessage;
            }
            set
            {
                ageMessage = value;
                OnPropertyChanged();
            }
        }

        private void Accept()
        {
            if (!user.DateOfBirthIsValid())
            {
                MessageBox.Show("Age is invalid!", "Error!");
                return;
            }
            WesternZodiac = user.WesternZodiac();
            ChineseZodiac = user.ChineseZodiac();
            if (user.BirthDayToday())
                AgeMessage = $"{user.Age()} y.o.   Happy Bithday! :)";
            else
                AgeMessage = $"{user.Age()} y.o.   Sadly, today is not your birthday :(";
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
