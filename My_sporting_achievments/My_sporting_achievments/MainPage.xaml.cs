using My_sporting_achievments.Services;
using My_sporting_achievments.ViewModels;
using My_sporting_achievments.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace My_sporting_achievments
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PasswordEntry.TextChanged += PasswordEntry_TextChanged;
            BindingContext = new MainPageViewModel();
            
        }

        private void PasswordEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = sender as Entry;
            if (entry.Text.Length == 0 || entry.Text.Length >= 8)
            {
                entry.TextColor = Color.Black;
            }
            else if (entry.Text.Length < 8)
            {
                entry.TextColor = Color.Red;
            }

        }
        void OnShowPassword(object sender, EventArgs args)
        {
            PasswordEntry.IsPassword = !PasswordEntry.IsPassword;
            if (PasswordEntry.IsPassword == true)
            {
                PasswordButton.Text = "*";
            }
            else
            {
                PasswordButton.Text = "%";
            }
        }
        
    }
}
