using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21___Matriz_transpuesta
{
    internal class Ejercicio21
    {
        static void Main()
        {
             /* 
                21. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N, 
                    muéstrela, halle la transpuesta y muestre el resultado. 
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

            int[,] mMatrizOriginal = new int[filas, columnas];
            int[,] mMatrizTranspuesta = new int[filas, columnas];

            // Rellenar matriz original y la transpuesta
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mMatrizOriginal[i, x] = random.Next(0, 10);
                    mMatrizTranspuesta[x, i] = mMatrizOriginal[i, x];
                }
            }

            // Mostrar resultados
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mMatrizOriginal[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Matriz transpuesta:");
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mMatrizTranspuesta[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
