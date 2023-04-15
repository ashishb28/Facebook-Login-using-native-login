using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin101.Services;
using Xamarin101.Views;

namespace Xamarin101
{
    public partial class App : Application
    {
        public IFacebookLoginService FacebookLoginService { get; private set; }

        public App(IFacebookLoginService facebookLoginService)
        {
            InitializeComponent();

            FacebookLoginService = facebookLoginService;

            MainPage = new XFFacebookExamplePage();
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
