using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
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
        async void OpenCooseWorcoutPageAsync()
        {
            await NavigationServices.NavigateToAsync(new ChooseWorkout());
            //Regex regex = new Regex("@");

            //if (PasswordEntry.Text.Length >= 8 && regex.IsMatch(LoginEntry.Text))
            //{
            //    await NavigationServices.NavigateToAsync(new ChooseWorkout(LoginEntry.Text));
            //}
            //else
            //{
            //    PasswordEntry.TextColor = Color.Red;
            //}
        }

        

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
