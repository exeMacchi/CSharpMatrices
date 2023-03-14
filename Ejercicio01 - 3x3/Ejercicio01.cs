using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01___3x3
{
    internal class Ejercicio01
    {
        static void Main()
        {
            // 1. Ingrese con números al azar del (0 al 9) una matriz de 3 x 3 y
            //    muéstrela.

            Random random = new Random();
            const int maxFilas = 3, maxColumnas = 3;
            int[,] mNumeros = new int[maxFilas, maxColumnas];

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);
                }
            }

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
