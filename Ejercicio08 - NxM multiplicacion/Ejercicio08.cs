using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08___NxM_multiplicacion
{
    internal class Ejercicio08
    {
        static void Main()
        {
            /* 
                8. Escriba un programa que genere una matriz de N x M con números al azar 
                   (del 1 al 9) y permita ingresar por teclado un numero para efectuar el 
                   producto con la matriz. La matriz resultante deberá ser un nueva y 
                   mostrarla. 
            */

            Random random = new Random();

            Console.Write("Ingrese la cantidad de filas: ");
            int filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la cantidad de columnas: ");
            int columnas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el producto: ");
            int numProducto = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[,] mNumeros = new int[filas, columnas];
            int[,] mProducto = new int[filas, columnas];

            // Inicialización y multiplicación
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    mNumeros[i, x] = random.Next(0, 10);
                    mProducto[i, x] = mNumeros[i, x] * numProducto;
                }
            }

            // Mostrar resultados
            Console.WriteLine("Matriz original:");
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mNumeros[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Matriz multiplicada:");
            for (int i = 0; i < filas; i++)
            {
                for (int x = 0; x < columnas; x++)
                {
                    Console.Write(mProducto[i, x] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
