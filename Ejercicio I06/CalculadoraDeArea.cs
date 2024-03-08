using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I06
{
    internal class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            double retorno;
            retorno = longitudLado * longitudLado;
            return retorno;
        }
        public static double CalcularAreaTriangulo(double baseArea, double altura) 
        {
            double retorno;
            retorno = (baseArea * altura) / 2;
            return retorno;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            double retorno;
            retorno = Math.PI * Math.Pow(radio, 2);
            return retorno;
        }
    }
}
