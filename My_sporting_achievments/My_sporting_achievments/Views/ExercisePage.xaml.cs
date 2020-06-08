using My_sporting_achievments.ViewModels;
using Xamarin.Forms;

namespace My_sporting_achievments.Views
{    
    public partial class ExercisePage : ContentPage
    {
        public ExercisePage()
        {
            Device.SetFlags(new[] { "CollectionView_Experimental", "Shell_Experimental" });
            InitializeComponent();
            BindingContext = new ExercisePageViewModel();
        }
        protected override async void OnAppearing()
        {

            await App.DataBase.CreateTable();

            exerciseList.ItemsSource = await App.DataBase.GetItemsAsync();

            base.OnAppearing();
        }

        //private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    OneExercise selectedExercise = (OneExercise)e.SelectedItem;
        //    TrainPage trainPage = new TrainPage();
        //    trainPage.BindingContext = selectedExercise;
        //    await Navigation.PushAsync(trainPage);
        //}
    }
}

