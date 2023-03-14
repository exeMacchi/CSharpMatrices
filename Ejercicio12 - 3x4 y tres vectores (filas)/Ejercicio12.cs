using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12___3x4_y_tres_vectores__filas_
{
    internal class Ejercicio12
    {
        static void Main()
        {
            /* 
                12. Ingrese con números al azar (del 0 al 9) una matriz de 3 x 4, 
                    muéstrela y cree 3 vectores que contengan el contenido de la
                    matriz por fila. 
            */

            Random random = new Random();
            const int maxFilas = 3, maxColumnas = 4;
            int[,] mNumeros = new int[maxFilas, maxColumnas];
            int[] vFila1 = new int[maxColumnas];
            int[] vFila2 = new int[maxColumnas];
            int[] vFila3 = new int[maxColumnas];

            // Rellenar la matriz y los vectores
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (i == 0)
                    {
                        vFila1[x] = mNumeros[i, x];
                    }
                    else if (i == 1)
                    {
                        vFila2[x] = mNumeros[i, x];
                    }
                    else if (i == 2)
                    {
                        vFila3[x] = mNumeros[i, x];
                    }
                }
            }

            // Mostrar la matriz original
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Mostrar los vectores en el formato matriz para enseñar resultados
            Console.WriteLine("Vectores en formato matriz:");
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    if (i == 0)
                    {
                        Console.Write(vFila1[x] + " ");
                        if (x == 3)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (i == 1)
                    {
                        Console.Write(vFila2[x] + " ");
                        if (x == 3)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (i == 2)
                    {
                        Console.Write(vFila3[x] + " ");
                        if (x == 3)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
