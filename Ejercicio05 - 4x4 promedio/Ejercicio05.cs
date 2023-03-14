using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05___4x4_promedio
{
    internal class Ejercicio05
    {
        static void Main()
        {
            /*
                5. Ingrese con números al azar del (0 al 9) una matriz de 4 x 4, 
                   muéstrela y halle el promedio.
            */

            Random random = new Random();
            const int maxFilas = 4, maxColumnas = 4;
            int[,] mNumeros = new int[maxFilas, maxColumnas];
            int acumulatorio = 0;

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);
                    acumulatorio += mNumeros[i, x];
                }
            }

            float promedio = acumulatorio / (float)(4 * 4);

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nPromedio de la matriz: {Math.Round(promedio, 2)}");
        }
    }
}
