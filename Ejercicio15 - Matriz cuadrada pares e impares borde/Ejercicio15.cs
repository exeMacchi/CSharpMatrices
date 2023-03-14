using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15___Matriz_cuadrada_pares_e_impares_borde
{
    internal class Ejercicio15
    {
        static void Main()
        {
            /* 
                15. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N 
                    y hallar la cantidad de números impares y pares que hay en sus bordes 
                    (no repetir sus vértices). 
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
            int cantNumPares = 0, cantNumImpares = 0;

            // Rellenar martiz y mostrarla
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

            // Proceso de verificación de pares e impares en los bordes de la matriz
            for (int i = 0; i < filas; i++)
            {
                if (i == 0)
                {
                    for (int x = 0; x < columnas; x++)
                    {
                        if (mNumeros[i, x] % 2 == 0)
                        {
                            cantNumPares++;
                        }
                        else
                        {
                            cantNumImpares++;
                        }
                    }
                }
                else if (i == (filas - 1))
                {
                    for (int x = 0; x < columnas; x++)
                    {
                        if (mNumeros[i, x] % 2 == 0)
                        {
                            cantNumPares++;
                        }
                        else
                        {
                            cantNumImpares++;
                        }
                    }
                }
                else
                {
                    if (mNumeros[i, 0] % 2 == 0)
                    {
                        cantNumPares++;
                    }
                    else
                    {
                        cantNumImpares++;
                    }

                    if (mNumeros[i, (columnas - 1)] % 2 == 0)
                    {
                        cantNumPares++;
                    }
                    else
                    {
                        cantNumImpares++;
                    }
                }
            }

            // Mostrar resultados
            Console.WriteLine($"Cantidad de números pares en los bordes de la matriz: " +
                              $"{cantNumPares}");
            Console.WriteLine($"Cantidad de números impares en los bordes de la matriz: " +
                              $"{cantNumImpares}");
            Console.WriteLine();
        }
    }
}
