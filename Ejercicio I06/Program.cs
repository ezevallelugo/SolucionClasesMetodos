/*
Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:

public double CalcularAreaCuadrado(double longitudLado) {}

public double CalcularAreaTriangulo(double base, double altura) {}

public double CalcularAreaCirculo(double radio) {}

El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */

namespace Ejercicio_I06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double longitudLado;
            double baseArea;
            double altura;
            double radio;
            double resultado;
            int seleccion;
            Console.WriteLine(@"Empieza el programa!");
            Console.WriteLine(@"Que desea calcular?
            1) Area Cuadrado
            2) Area Triangulo       
            3) Area Circulo");
            while (!int.TryParse(Console.ReadLine(), out seleccion) || seleccion < 1 || seleccion > 3)
            {
                Console.Write("Error. Ingrese una opcion valida: ");
            }
            switch (seleccion) 
            {
                case 1:
                    Console.Write("Ingrese la longitud del lado del cuadrado: ");
                    longitudLado = ValidarDouble();
                    resultado = CalculadoraDeArea.CalcularAreaCuadrado(longitudLado);
                    Console.WriteLine($"El resultado del area del cuadrado es: {resultado:F2}");
                    break;
                case 2:
                    Console.Write("Ingrese la base del triangulo: ");
                    baseArea = ValidarDouble();
                    Console.Write("Ingrese la altura del triangulo: ");
                    altura = ValidarDouble();
                    resultado = CalculadoraDeArea.CalcularAreaTriangulo(baseArea, altura);
                    Console.WriteLine($"El resultado del area del triangulo es: {resultado:F2}");
                    break;
                case 3:
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = ValidarDouble();
                    resultado = CalculadoraDeArea.CalcularAreaCirculo(radio);
                    Console.WriteLine($"El resultado del area del circulo es: {resultado:F2}");
                    break;
            }
            Console.WriteLine("Fin del programa!");
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