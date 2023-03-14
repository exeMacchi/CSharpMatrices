using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02___3x5
{
    internal class Ejercicio02
    {
        static void Main()
        {
            // 2. Ingrese vocales al azar a una matriz de 3 x 5 y muéstrela.

            Random random = new Random();
            char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
            const int maxFilas = 3, maxColumnas = 5;
            char[,] mVocales = new char[maxFilas, maxColumnas];

            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    int vocal = random.Next(0, 5);
                    mVocales[i, x] = vocales[vocal];
                }
            }

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
