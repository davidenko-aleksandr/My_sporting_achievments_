using My_sporting_achievments.Models;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace My_sporting_achievments.ViewModels
{
    public class OneExerciseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OneExercise OneExercise { get; set; }
        private string _nameExercise = string.Empty;
        private double _weight_1;
        private double _weight_2;
        private double _weight_3;
        private int _repetitions_1;
        private int _repetitions_2;
        private int _repetitions_3;
        private double _result;
        public ICommand ExerciseSelected { get; set; }

        public string NameExercise
        {
            get { return _nameExercise; }
            set 
            { 
                if (_nameExercise != value)
                    _nameExercise = value;
                OnPropertyChanged("NameExercise");
            }
        }
        public double Weight_1
        {
            get { return _weight_1; }
            set
            {
                if (_weight_1 != value)
                    _weight_1 = value;
                OnPropertyChanged("Weight_1");
            }
        }
        public double Weight_2
        {
            get { return _weight_2; }
            set
            {
                if (_weight_2 != value)
                    _weight_2 = value;
                OnPropertyChanged("Weight_2");
            }
        }
        public double Weight_3
        {
            get { return _weight_3; }
            set
            {
                if (_weight_3 != value)
                    _weight_3 = value;
                OnPropertyChanged("Weight_3");
            }
        }
        public int Repetitions_1
        {
            get { return _repetitions_1; }
            set
            {
                if (_repetitions_1 != value)
                    _repetitions_1 = value;
                OnPropertyChanged("Repetitions_1");
            }
        }
        public int Repetitions_2
        {
            get { return _repetitions_2; }
            set
            {
                if (_repetitions_2 != value)
                    _repetitions_2 = value;
                OnPropertyChanged("Repetitions_2");
            }
        }
        public int Repetitions_3
        {
            get { return _repetitions_3; }
            set
            {
                if (_repetitions_3 != value)
                    _repetitions_3 = value;
                OnPropertyChanged("Repetitions_3");
            }
        }
        public double Result
        {
            get { return _result; }
            set
            {
                if (_result != value)
                    _result = value;
                _result = (_weight_1 * _repetitions_1) + (_weight_2 * _repetitions_2)
                    + (_weight_3 * _repetitions_3);
                
                OnPropertyChanged("Result");
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}