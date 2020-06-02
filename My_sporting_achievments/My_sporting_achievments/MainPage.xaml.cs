using My_sporting_achievments.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace My_sporting_achievments
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();            
        }
    }
}
