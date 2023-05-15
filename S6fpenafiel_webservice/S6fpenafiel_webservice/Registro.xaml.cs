using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S6fpenafiel_webservice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Registro : ContentPage
	{
		public Registro ()
		{
			InitializeComponent ();
		}

        private void btnInsertar_Clicked(object sender, EventArgs e)
        {
			//controlo excepciones con try..catch para que no se congele la aplicacion
			try
			{
				//variable web client para consumir el servicio web
				//y poder insertar datos
				WebClient cliente = new WebClient();

				//variable tipo array para almacenar los datos
				var parametros = new System.Collections.Specialized.NameValueCollection();

				// en la variable parametos mando a guardar los datos ingresados (formato arreglo)
				parametros.Add("codigo",txtCodigo.Text); //guardo codigo 5
				parametros.Add("nombre",txtNombre.Text); //guardo freddy
				parametros.Add("apellido",txtApellido.Text); //guardo peniafiel
				parametros.Add("edad", txtEdad.Text); //29

				//envio los datos a la base, para la conexion la coloco con mi ip
				cliente.UploadValues("http://172.21.208.1/moviles/post.php", "POST",parametros);

				//mensaje que muestra cuando mis datos se han ingresado
				DisplayAlert("ALERTA", "DATO INGRESADO", "SALIR");



			}
			catch (Exception ex)
			{
				//muestro un mensaje de alerta junto con la excepcion
				//capturada en la variable ex
				DisplayAlert("ALERTA", ex.Message, "cerrar");
			}
        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
			//boton que regresa a la primera ventana
			Navigation.PushAsync(new principal());
        }
    }
}