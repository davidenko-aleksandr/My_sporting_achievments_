using My_sporting_achievments.Converters;
using My_sporting_achievments.ViewModels;
using System;
using Xamarin.Forms;


namespace My_sporting_achievments.Views
{
    public partial class TrainPage : ContentPage
    {

        OneExsToViewModelConverter oneExsTo = new OneExsToViewModelConverter();
        public OneExerciseViewModel ViewModel { get; set; }
        public TrainPage(OneExerciseViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }        
        private async void SaveExerciseClicked(object sender, EventArgs e)
        {
            var exercise = (OneExerciseViewModel)BindingContext;
            if (!String.IsNullOrEmpty(exercise.NameExercise))
            {
                await App.DataBase.SaveItemAsync(oneExsTo.ConvertToOneExs(exercise));
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteExerciseClicked(object sender, EventArgs e)
        {
            var exercise = (OneExerciseViewModel)BindingContext;
            await App.DataBase.DeleteItemAsync(oneExsTo.ConvertToOneExs(exercise));
            await this.Navigation.PopAsync();
        }
        private async void CancelClicked(object sender, EventArgs e) 
        {
            await this.Navigation.PopAsync();
        }
    }
}
