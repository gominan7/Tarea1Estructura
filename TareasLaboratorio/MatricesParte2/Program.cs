//Matrices//
//10-Suma dos matrices de difrentes tamaños

/*int[,] matriz1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
int[,] matriz2 = new int[2, 3] { { 7, 8, 0 }, {  9, 10, 0 } };

int[,] matrizSuma = new int[2, 3];

int filas = matriz1.GetLength(0);
int columnas = matriz1.GetLength(1);

for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        matrizSuma[i, j] = matriz1[i, j] + matriz2[i, j];
    }
}
Console.WriteLine("La matriz suma es:");
for (int i = 0; i < matrizSuma.GetLength(0); i++)
{
    for (int j = 0;j < matrizSuma.GetLength(1); j++)
    {
        Console.Write(matrizSuma[i, j] + " ");
    }
    Console.WriteLine();
}*/

//11-Multiplicar una matriz por un numero
/*int[,] matriz = new int[2, 4] { { 1,2, 0, 1}, { 3, 4, 5, 6} };
int n = 5;
int[,] matrizMulescalar = new int[2, 4]; 
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matrizMulescalar[i, j] = n * matriz[i, j];
    }
}
Console.WriteLine("Matris multiplicado por una escalar");
for (int i = 0;i < matrizMulescalar.GetLength(0); i++)
{
    for(int j = 0; j < matrizMulescalar.GetLength(1); j++)
    {
        Console.Write(matrizMulescalar[i, j] + " ");
    }
    Console.WriteLine();
}*/

//12-Calcula la media de una matriz
/*int[,] matriz = new int[3, 3] { { 1, 2, 3}, { 4, 5, 6}, { 7, 8, 9} };
int media, sumaElementos = 0;
for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        sumaElementos += matriz[i, j];
    }
}
media = sumaElementos / matriz.Length;
Console.WriteLine($"La media aritmetica es: {media}");*/

//MATRICES PARTE 2//
//Ejercicio 1: Crea una matriz de números aleatorios de tamaño 100 x 100.

/*Random random = new Random();
int filas = 100;
int columnas = 100;
int[,] matriz = new int[filas, columnas];
for (int i = 0; i < filas; i++)
{
    for (int j = 0; j < columnas; j++)
    {
        matriz[i, j] = random.Next(1000);
    }
}
Console.WriteLine("Elementos de la matriz con números aleatorios");
for (int i = 0;i < matriz.GetLength(0); i++)
{
    for (int j = 0;j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}*/

//Ejercicio 2: Calcula la media, mediana y la desviación estándar de los elementos de una matriz

//Media//
/*int[,] matriz = new int[3,3] { { 1, 2, 3},
                {4, 5, 6 }, {7, 8, 9}};

int media, sumaElementos = 0;

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        sumaElementos += matriz[i, j];
    }
}
media = sumaElementos / matriz.Length;

Console.WriteLine($"La media aritmetica de la matriz es: {media}");*/
//Mediana//
/*using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Define la matriz
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 15, 6 },
            { 7, 8, 9 }
        };

        // Aplana la matriz
        int[] vector = matriz.Cast<int>().ToArray();

        // Ordena los elementos
        Array.Sort(vector);

        // Encuentra la mediana
        int n = vector.Length;
        double mediana;
        if (n % 2 == 0)
        {
            mediana = (vector[n / 2 - 1] + vector[n / 2]) / 2.0;
        }
        else
        {
            mediana = vector[n / 2];
        }

        Console.WriteLine("La mediana de la matriz es: " + mediana);
    }
}*/

//Ejercicio3:Encuentre el elemento máximo de una matriz

/*using System;

class Program
{
    static void Main()
    {
        // Define la matriz
        int[,] matriz = new int[,]
        {
            { 1, 2, 3 },
            { 4, 15, 6 },
            { 7, 8, 9 }
        };

        // Encuentra el elemento máximo
        int maximo = EncontrarMaximo(matriz);

        Console.WriteLine("El elemento máximo de la matriz es: " + maximo);
    }

    static int EncontrarMaximo(int[,] matriz)
    {
        int maximo = matriz[0, 0]; // Inicializa con el primer elemento de la matriz

        // Recorre todos los elementos de la matriz
        foreach (int elemento in matriz)
        {
            if (elemento > maximo)
            {
                maximo = elemento; // Actualiza el máximo si se encuentra un valor mayor
            }
        }

        return maximo;
    }
}*/

//5-Enuentre una funión que encuentre la submatriz de mayor suma de una matriz

/*using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 1, -2, 3, 0 },
            { -4, 1, 0, -2 },
            { 3, -8, 5, 1 },
            { -1, 1, 3, -4 }
        };

        int[] resultado = SubmatrizMayorSuma(matriz);

        Console.WriteLine("La submatriz de mayor suma es:");
        for (int i = resultado[0]; i <= resultado[2]; i++)
        {
            for (int j = resultado[1]; j <= resultado[3]; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static int[] SubmatrizMayorSuma(int[,] matriz)
    {
        int rows = matriz.GetLength(0);
        int cols = matriz.GetLength(1);

        int[] resultado = new int[4];
        int maxSum = int.MinValue;

        for (int left = 0; left < cols; left++)
        {
            int[] temp = new int[rows];

            for (int right = left; right < cols; right++)
            {
                for (int i = 0; i < rows; i++)
                {
                    temp[i] += matriz[i, right];
                }

                int currentMax = MaxSubarraySum(temp, resultado);
                if (currentMax > maxSum)
                {
                    maxSum = currentMax;
                    resultado[1] = left;
                    resultado[3] = right;
                    resultado[0] = resultado[2];
                }
            }
        }

        return resultado;
    }

    static int MaxSubarraySum(int[] arr, int[] resultado)
    {
        int maxSum = int.MinValue;
        int currentSum = 0;
        int start = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                resultado[2] = i;
                resultado[0] = start;
            }

            if (currentSum < 0)
            {
                currentSum = 0;
                start = i + 1;
            }
        }

        return maxSum;
    }
}*/

//Ejercicio5:Escribe una función que encuentre la matriz de covarianza de dos matrices.
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Ejemplo de matrices
        double[,] X = new double[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        double[,] Y = new double[,]
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        double[,] covarianza = CalcularCovarianza(X, Y);

        // Imprime la matriz de covarianza
        Console.WriteLine("Matriz de covarianza:");
        for (int i = 0; i < covarianza.GetLength(0); i++)
        {
            for (int j = 0; j < covarianza.GetLength(1); j++)
            {
                Console.Write(covarianza[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static double[,] CalcularCovarianza(double[,] X, double[,] Y)
    {
        int n = X.GetLength(0); // Número de observaciones

        // Calcular las medias de cada variable en X e Y
        double[] mediaX = CalcularMedias(X);
        double[] mediaY = CalcularMedias(Y);

        // Calcular las matrices de desviaciones
        double[,] desviacionX = CalcularDesviaciones(X, mediaX);
        double[,] desviacionY = CalcularDesviaciones(Y, mediaY);

        // Calcular la matriz de covarianza
        double[,] covarianza = new double[desviacionX.GetLength(1), desviacionY.GetLength(1)];
        for (int i = 0; i < desviacionX.GetLength(1); i++)
        {
            for (int j = 0; j < desviacionY.GetLength(1); j++)
            {
                double sum = 0;
                for (int k = 0; k < n; k++)
                {
                    sum += desviacionX[k, i] * desviacionY[k, j];
                }
                covarianza[i, j] = sum / (n - 1);
            }
        }

        return covarianza;
    }

    static double[] CalcularMedias(double[,] matriz)
    {
        int n = matriz.GetLength(0);
        int m = matriz.GetLength(1);
        double[] medias = new double[m];

        for (int j = 0; j < m; j++)
        {
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matriz[i, j];
            }
            medias[j] = sum / n;
        }

        return medias;
    }

    static double[,] CalcularDesviaciones(double[,] matriz, double[] medias)
    {
        int n = matriz.GetLength(0);
        int m = matriz.GetLength(1);
        double[,] desviaciones = new double[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                desviaciones[i, j] = matriz[i, j] - medias[j];
            }
        }

        return desviaciones;
    }
}



