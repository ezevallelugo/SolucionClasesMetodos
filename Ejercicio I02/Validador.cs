using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    internal class Validador
    {
        public static bool ValidarRespuesta(string cadena)
        {
            bool retorno = true;
            string respuesta = cadena.ToUpper();
            if (respuesta != "S")
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
