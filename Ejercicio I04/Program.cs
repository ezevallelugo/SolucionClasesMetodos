/*
Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.

Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
Este método devolverá true si el operando es distinto de cero.

Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).

El usuario decidirá cuándo finalizar el programa.
 */

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numeroUno;
            double numeroDos;
            string operando;
            double resultado;

            Console.WriteLine("Empieza el prorgama!");
            while (true) 
            {                
                Console.Write("Ingrese el primer numero: ");
                while(!double.TryParse(Console.ReadLine(), out numeroUno))
                {
                    Console.WriteLine("Error. Ingrese un numero valido");
                }
                Console.Write("Ingrese el segundo numero: ");
                while (!double.TryParse(Console.ReadLine(), out numeroDos))
                {
                    Console.WriteLine("Error. Ingrese un numero valido");
                }
                Console.Write("Ingrese el operando (+,-,*,/): ");
                operando = Console.ReadLine();
                resultado = Calculadora.Calcular(numeroUno, numeroDos, operando);
                Console.WriteLine($"El resultado es: {resultado}");
                Console.Write("Desea continuar? (S|N): ");
                if (ValidarRespuesta(Console.ReadLine())) 
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Programa finalizado");
        }

        static bool ValidarRespuesta(string cadena)
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