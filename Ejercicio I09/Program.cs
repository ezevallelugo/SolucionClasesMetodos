/*
El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números 
enteros positivos que estén debajo de él, por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
 */
namespace Ejercicio_I09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int resultado;
            Console.WriteLine("Empieza el programa!");
            Console.Write("Ingrese un numero entero desde el 0 incluido: ");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || numeroIngresado < 0)
            {
                Console.Write("Error. Ingrese un numero valido desde el 0 incluido: ");
            }
            resultado = CalcularFactorial(numeroIngresado);
            Console.WriteLine($"El resultado es {resultado}.");
        }
        static int CalcularFactorial(int numeroIngresado) 
        {
            int retorno = 1;
            if (numeroIngresado > 0)
            {
                for (int i = 1; i <= numeroIngresado; i++)
                {
                    retorno *= i;
                }
            }            
            return retorno;
        }
    }
}