using Xamarin.Forms;

using Microsoft.Rest;

namespace NetStandardiOSLinkError
{
    public partial class App : Application
    {
        BasicAuthenticationCredentials _test;

        public App()
        {
            InitializeComponent();

            _test = new BasicAuthenticationCredentials();

            MainPage = new NetStandardiOSLinkErrorPage();
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
