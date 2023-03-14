using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11___Matriz_cuadrada_sumas_diagonales
{
    internal class Ejercicio11
    {
        static void Main()
        {
            /* 
                11. Ingrese con números al azar del (0 al 9) una matriz cuadrada de N x N, 
                    muéstrela y halle la sumatoria de la diagonal principal y diagonal 
                    inversa. 
            */

            Random random = new Random();

            int filas = 0, columnas = 0;
            // Pedir tamaño
            do
            {
                Console.Write("Ingrese la cantidad de filas: ");
                filas = int.Parse(Console.ReadLine());
                Console.Write("Ingrese la cantidad de columnas: ");
                columnas = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (filas != columnas)
                {
                    Console.WriteLine("Error: la cantidad de filas y columnas " +
                                      "debe ser igual.");
                }
            } while (filas != columnas);

            int[,] mNumeros = new int[filas, columnas];
            int sumaDiagonalPrincipal = 0, sumaDiagonalInversa = 0;

            // Rellenar la matriz y mostrarla
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

            // Suma diagonal principal
            for (int i = 0; i < filas; i++)
            {
                sumaDiagonalPrincipal += mNumeros[i, i]; 
            }

            // Suma diagonal inversa
            for (int i = 0, x = (columnas - 1); i < filas; i++, x--)
            {
                sumaDiagonalInversa += mNumeros[i, x]; 
            }

            // Resultados
            Console.WriteLine($"Suma diagonal principal: {sumaDiagonalPrincipal}");
            Console.WriteLine($"Suma diagonal inversa: {sumaDiagonalInversa}");
            Console.WriteLine();
        }
    }
}
