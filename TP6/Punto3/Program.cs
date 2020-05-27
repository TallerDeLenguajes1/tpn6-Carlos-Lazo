using System;
using static System.Math;
namespace Punto3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Ingrese un número");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"El cuadrado de {num} es {Math.Pow(num, 2)}");
                Console.WriteLine($"La raiz cuadrada de {num} es {Math.Sqrt(num)}");
                Console.WriteLine($"El seno de {num} es {Math.Sin(num)}");
                Console.WriteLine($"El coseno de {num} es {Math.Cos(num)}");
               
            
                Console.WriteLine("Ingrese un número con , flotante");
                double numF = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"La parte entera de {numF} es {Math.Truncate(numF)}");
                
                Console.WriteLine("Ingrese un número");
                int num1 = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Ingrese otro número");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"El máximo entre {num1} y {num2} es: {Math.Max(num1, num2)}");
                Console.WriteLine($"El mínimo entre {num1} y {num2} es: {Math.Min(num1, num2)}");
            
        }
    }
}
