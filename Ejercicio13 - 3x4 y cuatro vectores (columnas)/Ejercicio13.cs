using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13___3x4_y_cuatro_vectores__columnas_
{
    internal class Ejercicio13
    {
        static void Main()
        {
            /* 
                13. Ingrese con vocales al azar a una matriz de 3 x 4, muéstrela y cree 
                    4 vectores que contengan las vocales de la matriz por columna.
            */

            Random random = new Random();
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            const int maxFilas = 3, maxColumnas = 4;
            char[,] mVocales = new char[maxFilas, maxColumnas];
            char[] vocalesColumna1 = new char[maxColumnas];
            char[] vocalesColumna2 = new char[maxColumnas];
            char[] vocalesColumna3 = new char[maxColumnas];
            char[] vocalesColumna4 = new char[maxColumnas];

            // Rellenar matriz
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    int vocal = random.Next(0, 5);
                    mVocales[i, x] = vocales[vocal];

                }
            }

            // Rellenar vectores    
            for (int x = 0; x < maxColumnas; x++)
            {
                for (int i = 0; i < maxFilas; i++)
                {
                    if (x == 0)
                    {
                        vocalesColumna1[i] = mVocales[i, x];
                    }
                    else if (x == 1)
                    {
                        vocalesColumna2[i] = mVocales[i, x];
                    }
                    else if (x == 2)
                    {
                        vocalesColumna3[i] = mVocales[i, x];
                    }
                    else if (x == 3)
                    {
                        vocalesColumna4[i] = mVocales[i, x];
                    }
                }
            }

            // Mostrar matriz original
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mVocales[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
                
            // Mostrar contenido de los vectores
            for (int x = 0; x < maxColumnas; x++)
            {
                for (int i = 0; i < maxFilas; i++)
                {
                    if (x == 0)
                    {
                        Console.Write(vocalesColumna1[i] + " ");
                        if (i == 2)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (x == 1)
                    {
                        Console.Write(vocalesColumna2[i] + " ");
                        if (i == 2)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (x == 2)
                    {
                        Console.Write(vocalesColumna3[i] + " ");
                        if (i == 2)
                        {
                            Console.WriteLine();
                        }
                    }
                    else if (x == 3)
                    {
                        Console.Write(vocalesColumna4[i] + " ");
                        if (i == 2)
                        {
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
