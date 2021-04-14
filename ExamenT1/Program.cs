using System;
using T1Calidad;

namespace ExamenT1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bolos = new CodigoBolos(); 

            Console.WriteLine("Ingrese una cantidad de jugadores: ");
            int jugadores = Convert.ToInt32(Console.ReadLine());

            bolos.Algoritmo(jugadores);
        }
    }
}
