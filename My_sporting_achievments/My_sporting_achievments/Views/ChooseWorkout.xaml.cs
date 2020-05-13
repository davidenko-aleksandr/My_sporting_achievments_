using My_sporting_achievments.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_sporting_achievments.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseWorkout : ContentPage
    {
        public ChooseWorkout()
        {
            InitializeComponent();
        }
        async void OnStrongWorkoutClicked(object sender, EventArgs args)
        {
            await NavigationServices.NavigateToAsync(new ExercisePage());
        }
        async void OnCardioWorkoutClicked(object sender, EventArgs args)
        {
            await NavigationServices.NavigateToAsync(new CardioWorkoutPage());
        }
    }
}