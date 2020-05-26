using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
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
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}