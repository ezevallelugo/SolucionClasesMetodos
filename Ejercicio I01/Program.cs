/*
 Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:

bool Validar(int valor, int min, int max)

valor: dato a validar.
min: mínimo valor incluido.
max: máximo valor incluido.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
 */

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            int numeroIngresado;
            int maximo;
            int minimo;
            int acumulador = 0;
            double promedio;
            Console.WriteLine("Empieza el programa!");
            for (int i = 0; i < 10; i++) 
            {
                Console.Write($"Ingrese 10 numeros enteros ({i + 1}): ");
                while (!int.TryParse(Console.ReadLine(), out numeroIngresado) || !Validador.Validar(numeroIngresado, -100, 100))
                {
                    Console.WriteLine("Error. Ingrese un numero valido");
                }
                listaNumeros.Add(numeroIngresado);                
            }

            minimo = listaNumeros[0];
            maximo = listaNumeros[0];

            foreach (int numero in listaNumeros)
            {
                if (numero > maximo)
                {
                    maximo = numero;
                }
                if (numero < minimo)
                {
                    minimo = numero;
                }
                acumulador += numero;
            }

            promedio = (double)acumulador / listaNumeros.Count();
            Console.WriteLine($"Promedio: {promedio:F2}");
            Console.WriteLine($"Maximo: {maximo}");
            Console.WriteLine($"Minimo: {minimo}");

        }
    }
}