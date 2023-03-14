using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03___NxM
{
    internal class Ejercicio03
    {
 
        static void Main(string[] args)
        {
             /* 
                3. Ingrese un valor n y luego un valor m, a continuación inicializar con 
                   números al azar del (0 al 9) una matriz de n x m y muéstrela. 
            */

            Random random = new Random();

            
            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] mNumeros = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i,x] = random.Next(0, 10);
                }
            }

            Console.WriteLine();
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
