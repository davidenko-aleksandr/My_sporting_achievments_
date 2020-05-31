using My_sporting_achievments.ViewModels;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace My_sporting_achievments
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "exercises.db";
        public static ExerciseAsyncRepository database;
        public static ExerciseAsyncRepository DataBase
        {
            get
            {
                if (database == null)
                {
                    database = new ExerciseAsyncRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
