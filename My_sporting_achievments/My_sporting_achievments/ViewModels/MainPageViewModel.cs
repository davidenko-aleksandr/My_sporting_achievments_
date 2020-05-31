using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_sporting_achievments.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {       
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand _openChooseWorkoutPageCommand;

        public ICommand OpenChooseWorkoutPageCommand => _openChooseWorkoutPageCommand ??
            (_openChooseWorkoutPageCommand = new Command(OpenCooseWorcoutPageAsync));

        private string _password;
        public string Passward
        {
            get { return _password; }
            set
            {
                if (_password != null)
                {
                    _password = value;
                }
                
            }
        } 
        public bool ChangePasswColorTriger(bool colorRed)
        {
            colorRed = true;
            if (_password.Length < 8)
            {
                colorRed = false;
            }
            return colorRed;
        }
       
        private string _login;
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
        async void OpenCooseWorcoutPageAsync()
        {
            await NavigationServices.NavigateToAsync(new ChooseWorkout());
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(_login))
            {
                await NavigationServices.NavigateToAsync(new ChooseWorkout());
            }

        }



        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
