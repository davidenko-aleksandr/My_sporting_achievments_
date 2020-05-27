using My_sporting_achievments.Models;
using System;
using Xamarin.Forms;


namespace My_sporting_achievments.Views
{
    public partial class TrainPage : ContentPage
    {       
        public TrainPage()
        {
            InitializeComponent();
        }
        private async void SaveExerciseClicked(object sender, EventArgs e)
        {
            var exercise = (OneExercise)BindingContext;
            if (!String.IsNullOrEmpty(exercise.NameExercise))
            {
                await App.DataBase.SaveItemAsync(exercise);
            }
            await this.Navigation.PopAsync();
        }
        private async void DeleteExerciseClicked(object sender, EventArgs e)
        {
            var exercise = (OneExercise)BindingContext;
            await App.DataBase.DeleteItemAsync(exercise);
            await this.Navigation.PopAsync();
        }
        private async void CancelClicked(object sender, EventArgs e) 
        {
            await this.Navigation.PopAsync();
        }
    }
}
