using My_sporting_achievments.Services;
using My_sporting_achievments.ViewModels;
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
            BindingContext = new ChooseWorkoutPageViewModel();
        }


    }
}