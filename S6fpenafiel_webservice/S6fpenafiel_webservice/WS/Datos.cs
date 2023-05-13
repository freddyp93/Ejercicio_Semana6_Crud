using System;
using System.Collections.Generic;
using System.Text;

namespace S6fpenafiel_webservice.WS
{
    internal class Datos
    {
        //defino los atributos de la tabla que consta en la base
        //de datos con los metodos get y set

        //accedo a los datos
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
    }
}
