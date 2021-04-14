using System;
using System.Collections.Generic;
using System.Text;

namespace T1Calidad
{
    public class CodigoBolos
    {

        public void Algoritmo(int CantidadJugadores)
        {
            int resultado1 = 0;
            int a1 = 0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0, a9 = 0, a10 = 0, a11 = 0, a12 = 0, a13 = 0, a14 = 0, a15 = 0, a16 = 0, a17 = 0, a18 = 0, a19 = 0, a20 = 0;
            for (int j = 0; j < CantidadJugadores; j++)
            {
                resultado1 = resultado(a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20);
                Console.WriteLine("contador del jugador " + (j + 1) + " : " + resultado1);

            }
        }

        public int resultado(int a1, int a2, int a3, int a4, int a5, int a6, int a7, int a8, int a9, int a10, int a11, int a12, int a13, int a14, int a15, int a16, int a17, int a18, int a19, int a20)
        {
            List<int> numeros = new List<int>();
            numeros.Add(a1);
            numeros.Add(a2);
            numeros.Add(a3);
            numeros.Add(a4);
            numeros.Add(a5);
            numeros.Add(a6);
            numeros.Add(a7);
            numeros.Add(a8);
            numeros.Add(a9);
            numeros.Add(a10);
            numeros.Add(a11);
            numeros.Add(a12);
            numeros.Add(a13);
            numeros.Add(a14);
            numeros.Add(a15);
            numeros.Add(a16);
            numeros.Add(a17);
            numeros.Add(a18);
            numeros.Add(a19);
            numeros.Add(a20);

            int variable = 10;
            int contador = 0;
            int contador1 = 0;
            int suma = 0;
            string tipodeJuego = "";

            for (int i = 0; i < 10; i++)
            {
                int tiro1 = numeros[contador1];
                contador1++;
                int tiro2 = numeros[contador1];

                if (tiro1 != 10)
                {

                    if (tiro1 + tiro2 == 10)
                    {
                        contador = 20;
                        tipodeJuego = "pleno";
                    }

                    if (tiro1 + tiro2 != 10)
                    {
                        contador = tiro1 + tiro2;
                        tipodeJuego = "abierto";
                    }

                    if (tiro1 + tiro2 > 10)
                    {
                        tipodeJuego = "juego anulado por scores incorrectos";
                        contador = 0;
                    }
                }

                if (tiro1 == 10)
                {
                    contador = 30;
                    tipodeJuego = "strike";
                }

                Console.WriteLine("tiro 1: " + tiro1);
                Console.WriteLine("tiro 2: " + tiro2);
                Console.WriteLine("usted hizo un : " + tipodeJuego);

                suma = suma + contador;
                Console.WriteLine("total de partida: " + suma);
                Console.WriteLine("--------------------------------------------------- ");
                contador1++;
            }

            return suma;
        }
    }
}