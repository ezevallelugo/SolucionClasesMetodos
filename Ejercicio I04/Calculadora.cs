using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    internal class Calculadora
    {
        public static double Calcular(double numeroUno, double numeroDos, string operacion)
        {
            double resultado = 0.0;
            switch (operacion)
            {
                case "+":
                    resultado = numeroUno + numeroDos;
                    break;
                case "-":
                    resultado = numeroUno - numeroDos;
                    break;
                case "*":
                    resultado = numeroUno * numeroDos;
                    break;
                case "/":
                    if (Validar(numeroDos))
                    {
                        resultado = numeroUno / numeroDos;
                    }
                    else
                    {
                        Console.WriteLine("No se puede divir por 0");
                    }                    
                    break;
                default:
                    Console.WriteLine("Operando no valido");
                    break;
            }                
            return resultado;
        }

        private static bool Validar(double numeroDos)
        {
            bool retorno = true;
            if (numeroDos == 0)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
