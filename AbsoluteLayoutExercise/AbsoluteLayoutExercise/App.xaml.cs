using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AbsoluteLayoutExercise
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercise_One();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
