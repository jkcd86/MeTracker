using MeTracker.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MeTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = Resolver.Resolve<MainView>();

            isStartUp = false;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
            if(!isStartUp)
            {
                MainPage = Resolver.Resolve<MainView>();
            }
        }
    }
}
