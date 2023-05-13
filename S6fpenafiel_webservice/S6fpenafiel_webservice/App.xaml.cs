using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6fpenafiel_webservice
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //pagina desde la que va a iniciar la aplicacion
            MainPage = new principal();
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
