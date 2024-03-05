/*
Crear una aplicación de consola que permita al usuario ingresar un número entero.

Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.

Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.

Mostrar en la consola el resultado.

Por ejemplo, si se ingresa el número 2 la salida deberá ser:

Tabla de multiplicar del número 2:
2 x 1 = 2
2 x 2 = 4
2 x 3 = 6
2 x 4 = 8
2 x 5 = 10
2 x 6 = 12
2 x 7 = 14
2 x 8 = 16
2 x 9 = 18 
*/
using System.Text;

namespace Ejercicio_I05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string tabla;
            Console.WriteLine("Empieza el programa!");
            Console.Write("Ingrese un numero entero: ");
            while (!int.TryParse(Console.ReadLine(), out numeroIngresado))
            {
                Console.Write("Error. Ingrese un numero entero valido: ");
            }
            tabla = CrearTablaMultiplicacion(numeroIngresado);
            Console.WriteLine(tabla);
        }
        static string CrearTablaMultiplicacion(int numeroIngresado)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tabla de multiplicar del numero {numeroIngresado}:");
            for (int i = 1; i <= 9; i++)
            {
                int resultado = numeroIngresado * i;
                sb.AppendLine($"{numeroIngresado} * {i} = {resultado}");
            }
            return sb.ToString();
        }
    }
}