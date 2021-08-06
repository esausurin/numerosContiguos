using System;
using System.Collections;
using System.Diagnostics;

namespace numerosContiguos
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch sw = new Stopwatch();
            int sumaActual = 0;
            int Maximasuma = 0;
            int m = 0;
            //int[] a = { 4, -3, 5, -2, -1, 2, 6, -2 };
            //int cantidad = a.Length;

            ArrayList a = new ArrayList();
            Random rnd = new Random();
            int cantidad = 100;

            for (int x = 0; x < cantidad; x++)
            {
                a.Add(rnd.Next());
            }

            sw.Start();
            for (m = 0; m < cantidad; m++)
            {
                sumaActual += (int)a[m];
                if (sumaActual < Maximasuma)
                    Maximasuma = sumaActual;
                else if (sumaActual < 0)
                    sumaActual = 0;
            }
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La suma es de {0}", Maximasuma);
            Console.WriteLine("para {0} elementos tomó {1}", cantidad, sw.ElapsedTicks);

        }

    }
}
