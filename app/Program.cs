// Creamos un programa que ayuden a los usuarios a calcular el IVA

using System;

namespace ivaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa para calcular iva segun cantidad.

            double precio=0;

            Console.WriteLine ("Introduce número: ");
            precio = Convert.ToInt32( System.Console.ReadLine() );
            
            if (precio<=10)
            {
                double resulta= precio * 0.06;
                Console.WriteLine(resulta);
            }
            else if (precio>10)
            {
                double total= precio*0.21;
                Console.WriteLine(total);
            }
            else{
                Console.WriteLine("No introdujo el precio");
            } 


        }
    }
}