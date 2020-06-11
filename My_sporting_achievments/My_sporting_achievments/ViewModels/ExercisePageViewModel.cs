using My_sporting_achievments.Models;
using My_sporting_achievments.Services;
using My_sporting_achievments.Views;
using My_sporting_achievments.Converters;
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

        public INavigation Navigation { get; internal set; }

        //Переход на страницу редактирования упражнения (TrainPage)
        private async Task CheckExercise(object obj)
        {   //приводим полученный объект к типу "OneExercise"
            OneExercise exercise = (OneExercise)obj;
            //cоздаем объект для последующей конвертации в нужный нам тип "OneExerciseViewModel"
            OneExsToViewModelConverter oneExsTo = new OneExsToViewModelConverter();
            //открываем страницу редактирования и передаем в нее объкт нужного типа
            await NavigationServices.NavigateToAsync(new TrainPage(oneExsTo.ConvertTooneexsVM(exercise)));
        }
               
        //Переход на страницу создания физ. упражнения (TrainPage)
        private async Task AddNewTrainAsync()
        {
            //создаем объект нужного типа и передаем его на страницу создания физ.упражнения
            OneExerciseViewModel viewModel = new OneExerciseViewModel();
            await NavigationServices.NavigateToAsync(new TrainPage(viewModel));
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
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
