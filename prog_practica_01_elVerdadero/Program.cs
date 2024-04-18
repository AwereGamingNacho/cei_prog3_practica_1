using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicios

            // Nro. 1--
            //Console.WriteLine(esPrimo(2));
            //Nivel de complejidad cognitiva: [ 4 ]

            // Nro. 2--
            //Console.WriteLine(sumaDeDigitos(43));
            //Nivel de complejidad cognitiva: [ 1 ]

            // Nro. 3--
            //Console.WriteLine(numeroFactorial(5));
            //Nivel de complejidad cognitiva: [ 2 ]

            // Nro. 4--
            //Console.WriteLine(cantidadPalabrasEnString("Hola Mundo"));
            //Nivel de complejidad cognitiva: [ 5 ]

            // Nro. 5--
            //int[] numeros = { 3, 1, 7, 4, 5, 2, 9, 6, 8 };
            //numeros = ordenarSeleccion(numeros);
            //numeros.ToList().ForEach(x => Console.WriteLine(x));
            //Nivel de complejidad cognitiva: [ 5 ]

            // Nro. 6--
            //int[,] matriz1 = { { 12, 5, 30 } , { 12 , 5, 30 } };
            //int[,] matriz2 = { { 100, 43, 80 }, { 100, 3, 20 } };
            //int[,] matrizResultado = multiplicarMatrices(matriz1, matriz2);
            //for(int i = 0; i < matrizResultado.GetLength(0); i++)
            //{
            //    for(int j = 0; j < matrizResultado.GetLength(1); j++)
            //    {
            //        Console.WriteLine(string.Format("{0} ", matrizResultado[i,j]));
            //    }
            //}
            //Nivel de complejidad cognitiva: [ 11 ]

            // Nro. 7--
            //Console.WriteLine(esPlaindromo("adan nada"));
            //Nivel de complejidad cognitiva: [ 3 ]

            // Nro. 8--
            // Mismo ejercico que el anterior, solo que el codigo es peor.
            // Mismo nivel de complejidad.

            // Nro. 9--
            //Console.WriteLine(premutaciones(32, 10));
            //Nivel de complejidad cognitiva: [ 2 ]

            // Nro. 10--
            //Console.WriteLine(esAnagrama("caso", "saco"));
            //Nivel de complejidad cognitiva: [ 1 ]

            // Nro. 11--
            //Console.WriteLine(maximoComunDivisor(6, 4));
            //Nivel de complejidad cognitiva: [ 1 ]

            // Nro. 12--
            // Console.WriteLine(fibonacci(6));
            //Nivel de complejidad cognitiva: [ 2 ]

            // Nro. 13--
            // Console.WriteLine(fibonacci2(6));
            //Nivel de complejidad cognitiva: [ 3 ]

            // Nro. 14--
            //int[] nums = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(sumaArreglo(nums));
            //Nivel de complejidad cognitiva: [ 0 ]

            // Nro. 15--
            // Mismo ejercico que el ejercicio Nro. 11
            // Mismo nivel de complejidad.

            // Nro. 16--
            //int[,] a = { { 1, 2, 3, 4, }, { 1, 2, 3, 4 } };
            //Console.WriteLine(sumaMatriz(a));
            //Nivel de complejidad cognitiva: [ 3 ]

            // Nro. 17--
            //int[] numeros = { 3, 1, 7, 4, 5, 2, 9, 6, 8 };
            //Console.WriteLine(numeroMasGrande(numeros));
            //Nivel de complejidad cognitiva: [ 0 ]

            // Nro. 18--
            //Console.WriteLine(distanciaEuclidiana(4, 6, 10, 20));
            //Nivel de complejidad cognitiva: [ 0 ]
        }
        static bool esPrimo(int n)
        {
            if (n <= 1) //+1
            {
                return false;
            }
            for (int i = 0; i < Math.Sqrt(n); i++) //+1
            {
                if (i % n == 0) //+2
                {
                    return false;
                }
            }
            return true;
        }
        static int sumaDeDigitos(int n)
        {
            int suma = 0;
            while (n != 0) //+1
            {
                suma += n % 10;
                n /= 10;
            }
            return suma;
        }
        static int numeroFactorial(int n)
        {
            if (n <= 0) //+1
            {
                return 1;
            }
            int result = 1;
            for (int i = n; i > 0; i--) //+1
            {
                result *= i;
            }
            return result;
        }
        static int cantidadPalabrasEnString(string str)
        {
            int cant = 0;
            bool estaEnPalabra = false;
            foreach (char c in str) //+1
            {
                if (Char.IsWhiteSpace(c)) //+2
                {
                    estaEnPalabra = false;
                }
                else if (!estaEnPalabra) //+2
                {
                    cant++;
                    estaEnPalabra = true;
                }
            }
            return cant;
        }
        static int[] ordenarSeleccion(int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++) //+1
            {
                if (i < numeros.Length - 1) //+2
                {
                    if (numeros[i + 1] < numeros[i]) //+2
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[i + 1];
                        numeros[i + 1] = temp;
                        i = -1;
                    }
                }
            }
            return numeros;
        }
        static int[,] multiplicarMatrices(int[,] matriz1, int[,] matriz2)
        {
            int filas1 =  matriz1.GetLength(0);
            int columnas1 = matriz1.GetLength(1);
            int columnas2 = matriz2.GetLength(1);
            int[,] resultado = new int[filas1, columnas2];

            //esto da asco pero no me voy a tomar la molestia de implementar un mejor algoritmo
            //no me tomen como un persona ejemplar

            for (int i = 0; i < filas1; i++) //+1
            {
                if (i < filas1 - 1) //+2
                {
                    for (int j = 0; j < columnas2; j++) //+2
                    {
                        if (j < columnas2 - 1) //+2
                        {
                            for (int k = 0; k < columnas1; k++) //+2
                            {
                                if (k < columnas1 - 1) //+2
                                {
                                    resultado[i, j] += matriz1[i, k] * matriz2[k, j];
                                }
                            }
                        }
                    }
                }
            }
            return resultado;
        }
        static bool esPlaindromo(string cadena)
        {
            for (int i = 0, j = cadena.Length - 1; i < j; i++, j--) //+1
            {
                if (cadena[i] != cadena[j]) //+2
                {
                    return false;
                }
            }
            return true;
        }
        static int premutaciones(int n, int k)
        {
            if (n < k) //+1
            {
                return 0;
            }
            int resultado = 1;
            for (int i = n; i > n - k; i--) //+1
            {
                resultado *= i;
            }
            return resultado;
        } 
        static bool esAnagrama(string cadena1, string cadena2)
        {
            if (cadena1.Length != cadena2.Length) //+1
            {
                return false;
            }
            char[] chars1 = cadena1.ToCharArray();
            Array.Sort(chars1);
            string ordenada1 = new string(chars1);
            char[] chars2 = cadena2.ToCharArray();
            Array.Sort(chars2);
            string ordenada2 = new string(chars2);
            return ordenada1.Equals(ordenada2);
        }
        static int maximoComunDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int fibonacci(int n)
        {
            if(n <= 1)
            {
                return n;
            }
            int a = 0;
            int b = 1;
            for (int i = 2; i <= n; i++)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }
        static int fibonacci2(int n)
        {
            if (n==0)
            {
                return 0;
            }
            else if (n==1)
            {
                return 1;
            }
            else
            {
                return fibonacci(n-1) + fibonacci(n-2);
            }
        }
        static int sumaArreglo(int[] numeros)
        {
            return numeros.Sum();
        }
        static int sumaMatriz(int[,] matriz)
        {
            int suma = 0;
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += matriz[i, j];
                }
            }
            return suma;
        }
        static int numeroMasGrande(int[] numeros)
        {
            return numeros.Max();
        }
        static double distanciaEuclidiana(double x1, double y1, double x2, double y2)
        {
            double dx = x2 - x1;
            double dy = y2 - y1;
            return Math.Sqrt(dx * dx + dy * dy);
        }
    }
}
