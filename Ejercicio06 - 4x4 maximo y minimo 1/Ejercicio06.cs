using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06___4x4_maximo_y_minimo_1
{
    internal class Ejercicio06
    {
        static void Main()
        {
            /*
                6. Ingrese con números al azar del (0 al 9) una matriz de 4 x 4, 
                   muéstrela y halle el máximo y el mínimo.
            */

            Random random = new Random();
            const int maxFilas = 4, maxColumnas = 4;
            int[,] mNumeros = new int[maxFilas, maxColumnas];
            int maxNum = 0, minNum = 0;
            bool banMaxMin = false;

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (!banMaxMin)
                    {
                        maxNum = mNumeros[i, x];
                        minNum = mNumeros[i, x];
                        banMaxMin = true;
                    }
                    else
                    {
                        if (mNumeros[i, x] > maxNum)
                        {
                            maxNum = mNumeros[i, x];
                        }
                        if (mNumeros[i, x] < minNum)
                        {
                            minNum = mNumeros[i, x];
                        }
                    }
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"\nEl valor máximo: {maxNum}");
            Console.WriteLine($"El valor mínimo: {minNum}");
        }
    }
}
