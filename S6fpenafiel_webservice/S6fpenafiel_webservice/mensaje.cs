using System;
using System.Collections.Generic;
using System.Text;

namespace S6fpenafiel_webservice
{
    public interface mensaje
    {
        //defino un mensaje de alerta larga
        void longAlert(String Mensaje);

        //defino la alerta corta
        void shortAlert(String Mensaje);
    }
}
