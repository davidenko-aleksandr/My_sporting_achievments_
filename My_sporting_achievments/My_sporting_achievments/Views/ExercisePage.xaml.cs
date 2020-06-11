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
    }
}

