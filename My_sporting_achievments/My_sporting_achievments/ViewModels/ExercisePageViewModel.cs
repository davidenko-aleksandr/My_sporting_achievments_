using My_sporting_achievments.Models;
using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using System;
using System.Collections.Generic;
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
        public ObservableCollection<OneExercise> _trainCollection;
        public ObservableCollection<OneExercise> TrainCollection { get; set; }
        public ICommand _сreateTrainCommand;
        public ICommand CreateTrainCommand => _сreateTrainCommand ?? (_сreateTrainCommand = new Command(async () => await AddNewTrainAsync()));
        OneExercise OneExercise { get; set; }
        private async Task CheckExercise(object obj)
        {
            OneExercise oneExercise = (OneExercise)obj;
            TrainPage trainPage = new TrainPage(oneExercise);
            trainPage.BindingContext = oneExercise;
            await NavigationServices.NavigateToAsync(trainPage);
        }

        public INavigation Navigation { get; set; }
       
        //Переход на страницу создания физ. упражнения (TrainPage)
        private async Task AddNewTrainAsync()
        {
            OneExercise oneExercise = await App.DataBase.GetItemAsync(OneExercise.Id);
            TrainPage trainPage = new TrainPage(oneExercise);
            await NavigationServices.NavigateToAsync(trainPage);
        }
        public ExercisePageViewModel()
        {
            InitTable();            
        }

        //Получение таблицы из SQL 
        public async void InitTable()
        {
            //Создание таблицы, если ее нет
            await App.DataBase.CreateTable();
            //Получение данных из таблицы, для отображения на страцине
            TrainCollection = new ObservableCollection<OneExercise>(await App.DataBase.GetItemsAsync());
            ////при нажатии на упражнение переходим на страницу его редактирования
            TrainCollection.ForEach(c => c.ExerciseSelected = new Command<object>(async (oneExs) => await CheckExercise(oneExs))); 
            OnPropertyChanged("TrainCollection");
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
