using My_sporting_achievments.Models;
using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace My_sporting_achievments.ViewModels
{
    public class ExercisePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;      
        
        public ICommand _сreateTrainCommand;
        public ICommand CreateTrainCommand => _сreateTrainCommand ?? (_сreateTrainCommand = new Command(async () => await AddNewTrainAsync()));


        private async Task AddNewTrainAsync()
        {
            OneExercise oneExercise = new OneExercise();
            TrainPage trainPage = new TrainPage();
            trainPage.BindingContext = oneExercise;
            await NavigationServices.NavigateToAsync(trainPage);
        }
        public ExercisePageViewModel()
        {
            InitTable();           
            
        }
        public async void InitTable()
        {
            await App.DataBase.CreateTable();
            TrainCollection = new ObservableCollection<OneExercise>( await App.DataBase.GetItemsAsync());
            TrainCollection.ForEach(c => c.ExerciseSelected = new Command(async () => await AddNewTrainAsync()));

        }
        public ObservableCollection<OneExercise> _trainCollection;
        public ObservableCollection<OneExercise> TrainCollection;
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
