using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace My_sporting_achievments.Services
{
    public static class NavigationServices
    {
        private static Application CurrentApplication
        {
            get { return Application.Current; }
        }

        public static async Task NavigateToAsync(Page page)
        {
            if (CurrentApplication.MainPage is NavigationPage navigationPage)
            {
                await navigationPage.Navigation.PushAsync(page);
            }
        }
    }
}
