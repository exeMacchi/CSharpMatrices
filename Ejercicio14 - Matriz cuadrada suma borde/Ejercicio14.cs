using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14___Matriz_cuadrada_suma_borde
{
    internal class Ejercicio14
    {
        static void Main()
        {
            /* 
                14. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N
                    y halle la sumatoria de sus bordes. 
                    (No repetir la suma de sus vértices). 
            */

            Random random = new Random();

            // Pedir tamaño
            int filas = 0, columnas = 0;
            do
            {
                Console.Write("Ingrese la cantidad de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (filas != columnas)
                {
                    Console.WriteLine("Error: la cantidad de filas y columnas debe " +
                                      "ser igual.");
                }
            } while (filas != columnas);

            int[,] mNumeros = new int[filas, columnas];
            int sumatoriaBordes = 0;

            // Rellenar matriz y mostrarla
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Proceso de suma de los bordes de la matriz
            for (int i = 0; i < filas; i++)
            {
                if (i == 0)
                {
                    for (int x = 0; x < columnas; x++)
                    {
                        sumatoriaBordes += mNumeros[i, x];
                    }
                }
                else if (i == (filas - 1))
                {
                    for (int x = 0; x < columnas; x++)
                    {
                        sumatoriaBordes += mNumeros[i, x];
                    }
                }
                else
                {
                    sumatoriaBordes += mNumeros[i, 0];
                    sumatoriaBordes += mNumeros[i, (columnas - 1)];
                }
            }

            // Mostrar resultado
            Console.WriteLine($"Suma de los bordes de la matriz: {sumatoriaBordes}");
            Console.WriteLine();
        }
    }
}
