using System;

namespace Punto2
{
    class Punto2
    {
        static float suma(float a, float b)
        {
            return a + b;
        }
        static float resta(float a, float b)
        {
            return a - b;
        }

        static float multi(float a, float b)
        {
            return a * b;
        }

        static float div(float a, float b)
        {
            if (b != 0)
            {   
                return a/b;

            }else {

                Console.WriteLine("Division invalida(b=0) ");
                return 0;
            }
        }

        static float operaciones(int op, float a, float b){
            
            float ask = 0;

            switch (op)
            {
                case 1:
                    ask = suma(a, b);
                    break;
                case 2:
                    ask = resta(a, b);
                    break;
                case 3:
                    ask = multi(a, b);
                    break;
                case 4:
                    ask = div(a, b);
                    break;
            }

            return ask;

        }

        static void Main(string[] args)
        {
            char answ = 'n';
            int x;
            float a=0, b=0;
         
            do
            {
                Console.WriteLine("Ingrese operacion a realizar:");
                Console.WriteLine("1 - Suma (a + b)\n2 - Resta(a - b)\n3 - Multiplicacion(a * b)\n4 - Division Entera(a / b , b!=0)\n");
                x = Convert.ToInt32(Console.ReadLine());
                if (x>0 && x<5)
                {
                    Console.WriteLine("\nIngrese le valor de a");
                    a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("\nIngrese le valor de b");
                    b = Convert.ToInt32(Console.ReadLine());
                   
                    Console.WriteLine("Resultado: " + operaciones(x,a,b) );
                                    
                }
                else {

                    Console.WriteLine("Numero de operacion no valido");
                
                }
                Console.WriteLine("Desea hacer otra operacion? (Si = cualquier tecla/No = n)");
                answ = Convert.ToChar(Console.ReadLine());
                x = 0;
            } while (answ !='n');


        }

       
    }
}
