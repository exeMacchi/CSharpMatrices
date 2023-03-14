using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16___Matriz_cuadrada_suma_filas_impares
{
    internal class Ejercicio16
    {
        static void Main()
        {
            /* 
                16. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N 
                    y halle la sumatoria de los números en filas impares. 
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
            int sumatoriaFilasImpares = 0;

            // Rellenar la matriz acumulando filas impares
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (i % 2 != 0)
                    {
                        sumatoriaFilasImpares += mNumeros[i, x];
                    }

                }
            }
            
            // Mostrar la matriz
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                if (i % 2 != 0)
                {
                    Console.Write("----> Fila impar");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"Suma acumulada de filas impares: " +
                              $"{sumatoriaFilasImpares}");
        }
    }
}
