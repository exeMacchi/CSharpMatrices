using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22___Vector_de_vectores
{
    class Ejercicio22
    {
        static void Main()
        {
            /*
                22. Declarar un vector de vectores diferentes, es decir, una matriz que
                    tenga filas con un tamaño de columna distinto. Buscar el máximo por
                    fila y el máximo global.
            */
            const int FILAS = 2;
            int[] maxFilas = new int[FILAS];

            // Las columnas se declaran por separado (por cada fila).
            int[][] numeros = new int[FILAS][];

            // Rellenar 
            RellenarMatriz(numeros, FILAS);

            // Máximo por filas
            BuscarMaximoPorFila(numeros, maxFilas, FILAS);

            // Máximo global
            int maxGlobal = BuscarMaximoGlobal(numeros);

            // Mostrar matriz
            MostrarMatriz(numeros, FILAS);

            // Resultados
            MostrarResultados(maxFilas, FILAS, maxGlobal);
        }

        static void RellenarMatriz(int[][] numeros, in int FILAS)
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                Console.Write($"Ingrese el número de columnas para la fila {fila + 1}: ");
                int columnas = int.Parse(Console.ReadLine());

                numeros[fila] = new int[columnas];

                for (int columna = 0; columna < columnas; columna++)
                {
                    Console.Write($"Ingrese un número ({fila}-{columna}): ");
                    numeros[fila][columna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
        }

        static void BuscarMaximoPorFila(int[][] numeros, int[] maxFilas, in int FILAS)
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                maxFilas[fila] = MaximoFila(numeros[fila]);
            }
        }

        static int MaximoFila(int[] fila)
        {
            int maximo = 0;
            bool banMaximo = false;

            for (int columna = 0; columna < fila.Length; columna++)
            {
                if (!banMaximo)
                {
                    maximo = fila[columna];
                    banMaximo = true;
                }
                else if (fila[columna] > maximo)
                {
                    maximo = fila[columna];
                }
            }

            return maximo;
        }

        static int BuscarMaximoGlobal(int[][] numeros)
        {
            bool maximoGlobal = false;
            int maxGlobal = 0;

            foreach (int[] fila in numeros)
            {
                foreach (int numero in fila)
                {
                    if (!maximoGlobal)
                    {
                        maxGlobal = numero;
                        maximoGlobal = true;
                    }
                    else if (numero > maxGlobal)
                    {
                        maxGlobal = numero;
                    }
                }
            }

            return maxGlobal;
        } 

        static void MostrarMatriz(int[][] numeros, in int FILAS)
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                for (int columna = 0; columna < numeros[fila].Length; columna++)
                {
                    Console.Write(numeros[fila][columna] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void MostrarResultados(int[] maxFilas, in int FILAS, in int maxGlobal)
        {
            for (int fila = 0; fila < FILAS; fila++)
            {
                Console.WriteLine($"El máximo de la fila {fila + 1}: {maxFilas[fila]}");

            }
            Console.WriteLine($"El máximo global: {maxGlobal}");
        }
    }
}
