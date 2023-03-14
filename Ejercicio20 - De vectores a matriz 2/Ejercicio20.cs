using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20___De_vectores_a_matriz_2
{
    internal class Ejercicio20
    {
        static void Main()
        {
            /* 
                20. Ingrese 4 vectores de tamaño 5 con vocales al azar y cree una matriz 
                    de 5X4 que contenga las vocales de los vectores. 
            */

            Random random = new Random();

            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            const int maxFilas = 5, maxColumnas = 4;
            char[] vVocales1 = new char[maxFilas];
            char[] vVocales2 = new char[maxFilas];
            char[] vVocales3 = new char[maxFilas];
            char[] vVocales4 = new char[maxFilas];
            char[,] mVocales = new char[maxFilas, maxColumnas];

            // Rellenar los vectores
            for (int x = 0; x < maxColumnas; x++)
            {
                for (int i = 0; i < maxFilas; i++)
                {
                    if (x == 0)
                    {
                        int vocal = random.Next(0, 5);
                        vVocales1[i] = vocales[vocal];
                    }
                    else if (x == 1)
                    {
                        int vocal = random.Next(0, 5);
                        vVocales2[i] = vocales[vocal];
                    }
                    else if (x == 2)
                    {
                        int vocal = random.Next(0, 5);
                        vVocales3[i] = vocales[vocal];
                    }
                    else if (x == 3)
                    {
                        int vocal = random.Next(0, 5);
                        vVocales4[i] = vocales[vocal];
                    }
                }
            }
            
            // Rellenar matriz
            for (int x = 0; x < maxColumnas; x++)
            {
                for (int i = 0; i < maxFilas; i++)
                {
                    if (x == 0)
                    {
                        mVocales[i, x] = vVocales1[i];
                    }
                    else if (x == 1)
                    {
                        mVocales[i, x] = vVocales2[i];
                    }
                    else if (x == 2)
                    {
                        mVocales[i, x] = vVocales3[i];
                    }
                    else if (x == 3)
                    {
                        mVocales[i, x] = vVocales4[i];
                    }

                }
            }

            // Mostrar los vectores
            for (int x = 0; x < maxColumnas; x++)
            {
                Console.Write($"Vector {x + 1}: ");
                for (int i = 0; i < maxFilas; i++)
                {
                    if (x == 0)
                    {
                        Console.Write(vVocales1[i] + " ");
                    }
                    else if (x == 1)
                    {
                        Console.Write(vVocales2[i] + " ");
                    }
                    else if (x == 2)
                    {
                        Console.Write(vVocales3[i] + " ");
                    }
                    else if (x == 3)
                    {
                        Console.Write(vVocales4[i] + " ");
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
                    Console.Write(mVocales[i, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
