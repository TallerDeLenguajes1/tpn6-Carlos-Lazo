using System;


namespace TP6
{
    class Program
    {   

        static void Main(string[] args)
        {
            int num, aux = 0;
            Console.WriteLine("Ingrese el numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 0)
            {
                while(num > 0)
                {
                    aux = aux * 10 + num % 10;
                    num = num / 10;
                }

                Console.WriteLine("Numero invertido: " + aux);
            }
            else
            {
                Console.WriteLine("Numero negativo");
            }
            
      
           
        }
    }
}
