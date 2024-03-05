/*
 Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */
namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumulador = 0;
            Console.WriteLine("Empieza el programa!");
            while (true) 
            {
                Console.Write("Ingrese un numero entero positivo: ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    Console.Write("Error. Ingrese un numero entero valido: ");
                }
                acumulador += numeroIngresado;
                Console.WriteLine($"La suma hasta ahora es: {acumulador}");
                Console.Write("Desea continuar? (S/N): ");
                if (Validador.ValidarRespuesta(Console.ReadLine())) 
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Fin del programa!");
        }
    }
}