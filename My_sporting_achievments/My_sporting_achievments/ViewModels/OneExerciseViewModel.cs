using My_sporting_achievments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace My_sporting_achievments.ViewModels
{
    public class OneExerciseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public OneExercise OneExercise { get; set; }
        public OneExerciseViewModel()
        {
            OneExercise = new OneExercise();
        }
        public string NameExercise
        {
            get { return OneExercise.NameExercise; }
            set 
            { 
                if (OneExercise.NameExercise != value)
                    OneExercise.NameExercise = value;
                OnPropertyChanged("NameExercise");
            }
        }
        public double Weight_1
        {
            get { return OneExercise.Weight_1; }
            set
            {
                if (OneExercise.Weight_1 != value)
                    OneExercise.Weight_1 = value;
                OnPropertyChanged("Weight_1");
            }
        }
        public double Weight_2
        {
            get { return OneExercise.Weight_2; }
            set
            {
                if (OneExercise.Weight_2 != value)
                    OneExercise.Weight_2 = value;
                OnPropertyChanged("Weight_2");
            }
        }
        public double Weight_3
        {
            get { return OneExercise.Weight_3; }
            set
            {
                if (OneExercise.Weight_3 != value)
                    OneExercise.Weight_3 = value;
                OnPropertyChanged("Weight_3");
            }
        }
        public int Repetitions_1
        {
            get { return OneExercise.Repetitions_1; }
            set
            {
                if (OneExercise.Repetitions_1 != value)
                    OneExercise.Repetitions_1 = value;
                OnPropertyChanged("OneExercise.Repetitions_1");
            }
        }
        public int Repetitions_2
        {
            get { return OneExercise.Repetitions_2; }
            set
            {
                if (OneExercise.Repetitions_2 != value)
                    OneExercise.Repetitions_2 = value;
                OnPropertyChanged("OneExercise.Repetitions_2");
            }
        }
        public int Repetitions_3
        {
            get { return OneExercise.Repetitions_3; }
            set
            {
                if (OneExercise.Repetitions_3 != value)
                    OneExercise.Repetitions_3 = value;
                OnPropertyChanged("OneExercise.Repetitions_3");
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
