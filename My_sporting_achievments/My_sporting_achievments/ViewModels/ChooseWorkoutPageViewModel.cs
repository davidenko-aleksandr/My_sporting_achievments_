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
    public class ChooseWorkoutPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ICommand _openExercisePageCommand;
        public ICommand OpenExercisePageCommand => _openExercisePageCommand ?? (_openExercisePageCommand = new Command(OpenExercisePageAsync));

        private async void OpenExercisePageAsync()
        {
            await NavigationServices.NavigateToAsync(new ExercisePage());
           
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
