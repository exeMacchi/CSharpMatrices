using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17___Matriz_cuadrada_suma_columnas_pares
{
    internal class Ejercicio17
    {
        static void Main()
        {
            /* 
                17. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N 
                    y halle la sumatoria de los números en columnas pares. 
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
            int sumatoriaColumnasPares = 0;

            // Rellenar matriz y sumar columnas pares
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (x % 2 == 0)
                    {
                        sumatoriaColumnasPares += mNumeros[i, x];
                    }
                }
            }

            // Mostrar cuáles columnas son las pares
            for (int x = 0; x < columnas; x++)
            {
                if (x % 2 == 0)
                {
                    Console.Write("v ");
                }
                else
                {
                    Console.Write("  ");
                }
            }
            Console.WriteLine();

            // Mostrar matriz y resultados
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Suma acumulada de columnas pares: " +
                              $"{sumatoriaColumnasPares}");
        }
    }
}
