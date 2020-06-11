using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace My_sporting_achievments.ViewModels
{
    public class TrainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ICommand _saveExerciseCommand;
        public ICommand SaveExerciseCommand => _saveExerciseCommand ?? (_saveExerciseCommand = new Command(SaveExercise));

        private void SaveExercise()
        {
            throw new NotImplementedException();
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}