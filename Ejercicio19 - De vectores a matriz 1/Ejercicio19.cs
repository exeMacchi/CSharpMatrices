using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19___De_vectores_a_matriz_1
{
    internal class Ejercicio19
    {
        static void Main()
        {
             /* 
                19. Ingrese 3 vectores de 4 elementos cada uno con números al azar 
                    (del 1 al 9) y cree una matriz de 3x4 que contenga los elementos 
                    de los vectores. 
            */

            Random random = new Random();

            const int maxFilas = 3, maxColumnas = 4;
            int[] vNumeros1 = new int[maxColumnas];
            int[] vNumeros2 = new int[maxColumnas];
            int[] vNumeros3 = new int[maxColumnas];

            int[,] mNumeros = new int[maxFilas, maxColumnas];

            // Proceso de rellenar la matriz con los vectores 
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    if (i == 0)
                    {
                        vNumeros1[x] = random.Next(1, 10);
                        mNumeros[i, x] = vNumeros1[x];
                    }
                    else if (i == 1)
                    {
                        vNumeros2[x] = random.Next(1, 10);
                        mNumeros[i, x] = vNumeros2[x];
                    }
                    else if (i == 2)
                    {
                        vNumeros3[x] = random.Next(1, 10);
                        mNumeros[i, x] = vNumeros3[x];
                    }

                }
            }
            
            // Mostrar los vectores
            for (int i = 0; i < maxFilas; i++)
            {
                Console.Write($"Vector {i + 1}: ");
                for (int x = 0; x < maxColumnas; x++)
                {
                    if (i == 0)
                    {
                        Console.Write(vNumeros1[x] + " "); 
                    }
                    else if (i == 1)
                    {
                        Console.Write(vNumeros2[x]+ " ");
                    }
                    else if (i == 2)
                    {
                        Console.Write(vNumeros3[x] + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrar la matriz
            Console.WriteLine("Matriz:");
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
