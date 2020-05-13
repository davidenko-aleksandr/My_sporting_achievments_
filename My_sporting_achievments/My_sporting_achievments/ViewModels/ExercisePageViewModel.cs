using My_sporting_achievments.Models;
using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_sporting_achievments.ViewModels
{
    public class ExercisePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public ICommand CreateTrainCommand { get; }

        INavigation Navigation { get; set; }
        public ExercisePageViewModel()
        {
            CreateTrainCommand = new Command(AddNewTrain);
        }
        private async void AddNewTrain()
        {
            OneExercise oneExercise = new OneExercise();
            TrainPage trainPage = new TrainPage();
            trainPage.BindingContext = oneExercise;
            await Navigation.PushAsync(trainPage);
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
