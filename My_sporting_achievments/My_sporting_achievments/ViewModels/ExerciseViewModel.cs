using My_sporting_achievments.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace My_sporting_achievments.ViewModels
{
    public class ExerciseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        //public OneExercise OneExercise { get; private set; }
        //public ExerciseViewModel()
        //{
        //    OneExercise = new OneExercise();
        //}

        //public string NameExercise
        //{
        //    get { return OneExercise.NameExercise; }
        //    set
        //    {
        //        if (OneExercise.NameExercise != value)
        //        {
        //            OneExercise.NameExercise = value;
        //            OnPropertyChanged("NameExercise");
        //        }
        //    }
        //}

        //public double Weight
        //{
        //    get { return OneExercise.Weight; }
        //    set
        //    {
        //        if (OneExercise.Weight != value)
        //        {
        //            OneExercise.Weight = value;
        //            OnPropertyChanged("Weight");
        //        }
        //    }
        //}
        //public int Repetitions
        //{
        //    get { return OneExercise.Repetitions; }
        //    set
        //    {
        //        if (OneExercise.Repetitions != value)
        //        {
        //            OneExercise.Repetitions = value;
        //            OnPropertyChanged("Repetitions");
        //        }
        //    }
        //}
        //public bool IsValid
        //{
        //    get
        //    {
        //        return ((!string.IsNullOrEmpty(NameExercise.Trim())));
        //    }
        //}
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

