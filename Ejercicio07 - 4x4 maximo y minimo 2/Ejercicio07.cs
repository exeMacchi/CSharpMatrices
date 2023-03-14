using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07___4x4_maximo_y_minimo_2
{
    internal class Ejercicio07
    {
        static void Main()
        {
            /*
                7. Ídem al ejercicio anterior, pero, además, deberá mostrar su ubicación
                   (fila, columna).
            */

            Random random = new Random();
            const int maxFilas = 4, maxColumnas = 4;
            int[,] mNumeros = new int[maxFilas, maxColumnas];
            int maxNum = 0, minNum = 0, 
                iMaxNum = 0, xMaxNum = 0, 
                iMinNum = 0, xMinNum = 0;

            // Proceso inicalización y verificación de máximos y mínimos
            for (int i = 0; i < maxFilas; i++)
            {
                for (int x = 0; x < maxColumnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);

                    if (i == 0 && x == 0)
                    {
                        maxNum = mNumeros[i, x];
                        iMaxNum = i;
                        xMaxNum = x;

                        minNum = mNumeros[i, x];
                        iMinNum = i;
                        xMinNum = x;
                    }
                    else
                    {
                        if (mNumeros[i, x] > maxNum)
                        {
                            maxNum = mNumeros[i, x];
                            iMaxNum = i;
                            xMaxNum = x;
                        }

                        if (mNumeros[i, x] < minNum)
                        {
                            minNum = mNumeros[i, x];
                            iMinNum = i;
                            xMinNum = x;
                        }
                    }
                }
            }

            // Mostrar la matriz
            for (int i = 0; i < 4; i++)
            {
                for (int x = 0; x < 4; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Resultados
            Console.WriteLine($"\nValor máximo: {maxNum} ({iMaxNum + 1}-{xMaxNum + 1})");
            Console.WriteLine($"Valor mínimo: {minNum} ({iMinNum + 1}-{xMinNum + 1})");
        }
    }
}
