/*
Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual.
Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos 
por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 */
namespace Ejercicio_I08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;
            Console.WriteLine("Empieza el programa!");
            Console.Write("Ingrese el dia: ");
            dia = ValidarInt(1, 31);
            Console.Write("Ingrese el mes: ");
            mes = ValidarInt(1, 12);
            Console.Write("Ingrese el anio: ");
            anio = ValidarInt(1, 2024);
            DateTime fechaInicio = new DateTime(anio, mes, dia);
            DateTime fechaActual = DateTime.Today;
            TimeSpan diferencia = fechaActual - fechaInicio;
            Console.WriteLine($"La cantidad de dias que pasaron es de {diferencia.TotalDays}");
        }

        static int ValidarInt(int min, int max)
        {
            int resultado;
            while (!int.TryParse(Console.ReadLine(), out resultado) || resultado < min || resultado > max) 
            {
                Console.Write($"Error. Ingrese un numero valido entre {min} y {max}: ");
            }
            return resultado;
        }
    }
}