﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6fpenafiel_webservice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class principal : ContentPage
    {
        //variables de clase
        //declaro la variable Url y le paso la direccion de
        //mi web service
        //http//direccionIpV4 para la conexion
        private const string Url = "http://172.21.208.1/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        
        //accedo a la clase datos para obtener los campos de la tabla
        private ObservableCollection<S6fpenafiel_webservice.WS.Datos> _post;



        public principal()
        {
            InitializeComponent();

            //llamo al metodo obtener para mostrar los datos
            Obtener();
           
        }

        //creo un metodo para mostrar los datos cuando se cargue la aplicacion
        public async void Obtener()
        {
            //creo una variable que obtenga el string de la URL
            var content = await client.GetStringAsync(Url);

            //creo una lista del mismo tipo de la clase que se creo
            //se convierte a JSON deserializado lo que viene
            List<S6fpenafiel_webservice.WS.Datos> posts = JsonConvert.DeserializeObject<List<S6fpenafiel_webservice.WS.Datos>>(content);

            //almaceno en una variable post el deserealizado
            //se almacena en una variable por que no se puede enviar directamente
            //al list view es mejor almacenar en una variable
            _post = new ObservableCollection<S6fpenafiel_webservice.WS.Datos>(posts);

            //muestro mis datos en el list view
            MyListView.ItemsSource = _post;
        }
        // private async void btnGet_Clicked(object sender, EventArgs e)
        // {
            //creo una variable que obtenga el string de la URL
            //la URL devuelve un string deserializado

          //  var content = await client.GetStringAsync(Url);

            //creo una lista del mismo tipo de la clase que se creo
            //se convierte a JSON deserializado lo que viene

           // List<S6fpenafiel_webservice.WS.Datos> posts = JsonConvert.DeserializeObject<List<S6fpenafiel_webservice.WS.Datos>>(content);

            //almaceno en una variable post el deserealizado
            //se almacena en una variable por que no se puede enviar directamente
            //al list view es mejor almacenar en una variable

           // _post = new ObservableCollection<S6fpenafiel_webservice.WS.Datos>(posts);

            //acceso al elemento list view para enviar el item de la variable
            //post, que es el post del web service

           // MyListView.ItemsSource = _post;

       // }

        private void btnregistrar_Clicked(object sender, EventArgs e)
        {
            //codigo para navegacion entre ventanas
            //desde la ventana principal hasta la navegacion registro
            //desde el boton registro

            //alerta Toast (mensaje superpuesto)
            var mensaje = "BIENVENIDO";
            DependencyService.Get<mensaje>().longAlert(mensaje);
            
            Navigation.PushAsync(new Registro());
        }

        //metodo para seleccionar cada item del List View
        private void MyListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //creo una variable de tipo datos
            var obj = (WS.Datos)e.SelectedItem;
        }
    }
}