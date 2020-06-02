using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_sporting_achievments.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {       
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand _openChooseWorkoutPageCommand;
        private ICommand _registrationCommand;
        private ICommand _changeImageCommand;
        private string _login = string.Empty;
        private string _password = string.Empty;
        private bool _isShowImage = true;
        public ICommand OpenChooseWorkoutPageCommand => _openChooseWorkoutPageCommand ??
           (_openChooseWorkoutPageCommand = new Command(OpenCooseWorcoutPageAsync));
        public ICommand RegistrationCommand => _registrationCommand ??
            (_registrationCommand = new Command(RegistrationUrl));
        public ICommand ChangeImageCommand => _changeImageCommand ??
            (_changeImageCommand = new Command(OnShowPassword));

        private void OnShowPassword(object obj)
        {
            IsShowImage = !IsShowImage;
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value )
                {
                    _password = value;
                }
                OnPropertyChanged("Password");
            }
        }    
         public string Login
        {
            get { return _login; }
            set
            {
                if (_login != value)
                {
                    _login = value;
                    OnPropertyChanged("Login");
                }                
            }
            
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
        async void OpenCooseWorcoutPageAsync()
        {
            await NavigationServices.NavigateToAsync(new ChooseWorkout());
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(_login))
            {
                await NavigationServices.NavigateToAsync(new ChooseWorkout());
            }            
        }
        private void RegistrationUrl()
        {
            Device.OpenUri(new Uri("http://htmlbook.ru/practical/forma-registratsii"));
        }
        public bool IsShowImage
        {
            get { return _isShowImage; }
            set
            {
                if (_isShowImage != value)
                {
                    _isShowImage = value;
                }
                OnPropertyChanged("IsShowImage");
            }
        }
    }
}
