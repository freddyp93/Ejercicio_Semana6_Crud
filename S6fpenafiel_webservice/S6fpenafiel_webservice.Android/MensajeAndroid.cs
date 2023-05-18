using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using S6fpenafiel_webservice.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
[assembly: Xamarin.Forms.Dependency(typeof(MensajeAndroid))] //este archivo debe considerarse al momento de ejecutar la aplicacion
namespace S6fpenafiel_webservice.Droid
{
    public class MensajeAndroid : mensaje
    {
        //implemento la interfaz mensaje que ya cree
        public void longAlert(string Mensaje)
        {
            Toast.MakeText(Application.Context, Mensaje, ToastLength.Long).Show(); //5 segundos de duracion
        }

        public void shortAlert(string Mensaje)
        {
            Toast.MakeText(Application.Context, Mensaje, ToastLength.Short).Show(); //3 segundos de duracion
        }
    }
}