using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04___NxM_suma
{
    internal class Ejercicio04
    {
        static void Main()
        {
            /*
                4. Ingrese con números al azar del (0 al 9) una matriz de N x M, 
                   muéstrela y halle la sumatoria.
            */

            Random random = new Random();

            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] mNumeros = new int[filas, columnas];
            int sumatoria = 0;

            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    sumatoria += mNumeros[i, x];
                }
            }

            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\nLa suma total de la matriz: {sumatoria}");
        }
    }
}
