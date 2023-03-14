using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09___4x4_sumatoria
{
    internal class Ejercicio09
    {
        static void Main()
        {
            /* 
                9. Ingrese con números al azar del (0 al 9) dos matrices de 4 x 4, 
                   muéstrelas y halle la suma en una nueva matriz. 
            */

            Random random = new Random();
            const int maxFilas = 4, maxColumnas = 4;
            int[,] mNumeros1 = new int[maxFilas, maxColumnas];
            int[,] mNumeros2 = new int[maxFilas, maxColumnas];
            int[,] mSuma = new int[maxFilas, maxColumnas];

            // Proceso de inicialización y suma
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros1[i, x] = random.Next(0, 10);
                    mNumeros2[i, x] = random.Next(0, 10);
                    mSuma[i, x] = mNumeros1[i, x] + mNumeros2[i, x];
                }
            }

            // Resultados
            Console.WriteLine("Primera matriz: ");
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mNumeros1[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Segunda matriz: ");
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mNumeros2[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.WriteLine("Suma de matrices: ");
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mSuma[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
