using My_sporting_achievments.Models;
using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_sporting_achievments.ViewModels
{
    public class ExercisePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;      
        
        public ICommand _сreateTrainCommand;
        public ICommand CreateTrainCommand => _сreateTrainCommand ?? (_сreateTrainCommand = new Command(AddNewTrainAsync));


        private async void AddNewTrainAsync()
        {
            OneExercise oneExercise = new OneExercise();
            TrainPage trainPage = new TrainPage();
            trainPage.BindingContext = oneExercise;
            await NavigationServices.NavigateToAsync(trainPage);
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
