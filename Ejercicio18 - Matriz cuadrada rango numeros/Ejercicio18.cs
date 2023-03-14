using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18___Matriz_cuadrada_rango_numeros
{
    internal class Ejercicio18
    {
        static void Main()
        {
            /* 
                18. Ingrese con números al azar (del 0 al 9) una matriz cuadrada de N x N 
                    y halle la cantidad de números menores a 4 y entre 4 y 7. 
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
            int cantNumMenoresA4 = 0, cantNumEntre4Y7 = 0;

            // Rellenar matriz y verificar rango pedido  
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (mNumeros[i, x] < 4)
                    {
                        cantNumMenoresA4++;
                    }
                    else if (mNumeros[i, x] >= 4 && mNumeros[i, x] <= 7)
                    {
                        cantNumEntre4Y7++;
                    }
                }
            }

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

            Console.WriteLine($"Cantidad de números menores a 4: {cantNumMenoresA4}");
            Console.WriteLine($"Cantidad de números entre 4 y 7: {cantNumEntre4Y7}");
            Console.WriteLine();
        }
    }
}
