using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10___3x5_promedio_fila_y_columna
{
    internal class Ejercicio10
    {
        static void Main()
        {
            /* 
                10. Ingrese con números al azar del (0 al 9) una matriz m1 de 3 x 5 y 
                    muéstrela. Además, se pide hallar los promedios por fila y por 
                    columna (mostrar los resultados). 
            */

            Random random = new Random();
            const int maxFilas = 3, maxColumnas = 5;
            int[,] mNumeros = new int[maxFilas, maxColumnas];
            int[] acumFilas = new int[maxFilas]; 
            int[] acumColumnas = new int[maxColumnas];
            float[] promedioFilas = new float[maxFilas];
            float[] promedioColumnas = new float[maxColumnas];

            // Rellenando matriz
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);
                }
            }

            // Acumulador y promedio filas
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    acumFilas[i] += mNumeros[i, x];
                }
                promedioFilas[i] = acumFilas[i] / (float) maxColumnas;
            }

            // Acumulador y promedio columnas
            for (int x = 0; x < maxColumnas; x++)
            {
                for (int i = 0; i < maxFilas; i++)
                {
                    acumColumnas[x] += mNumeros[i, x];
                }
                promedioColumnas[x] = acumColumnas[x] / (float) maxFilas;
            }

            // Resultados
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < maxFilas; i++)
            {
                Console.WriteLine($"Promedio fila {i + 1}: " +
                                  $"{Math.Round(promedioFilas[i], 2)}");
            }
            Console.WriteLine();

            for (int x = 0; x < maxColumnas; x++)
            {
                Console.WriteLine($"Promedio columna {x + 1}: " +
                                  $"{Math.Round(promedioColumnas[x], 2)}");
            }
            Console.WriteLine();
        }
    }
}
