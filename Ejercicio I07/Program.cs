/*
Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
 */
namespace Ejercicio_I07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;
            double resultado;
            Console.WriteLine("Empieza el programa para calcular la hipotenusa!");
            Console.Write("Ingrese la base del triangulo (cm): ");
            baseTriangulo = ValidarDouble();
            Console.Write("Ingrese la altura del triangulo (cm): ");
            altura = ValidarDouble();
            resultado = Math.Sqrt(Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2));
            Console.WriteLine($"Segun Pitágoras, el resultado es {resultado:F4}");
        }
        static double ValidarDouble()
        {
            double resultado;
            while (!double.TryParse(Console.ReadLine(), out resultado))
            {
                Console.Write("Error. Ingrese un numero valido: ");
            }
            return resultado;
        }
    }
}