//RECURSIVIDAD//
//1-Escrirba una función recursiva que imprima los números
//pares de 1 al 100
/*class Program
{
    static void imprimirPares(int numero)
    {
        if (numero <= 100)
        {
            if (numero % 2 == 0)
            {
                Console.Write(numero + " ");
            }
            imprimirPares(numero + 1);
        }
    }

    static void Main(string[] args)
    {
        imprimirPares(1);
    }
}*/

//2-Escribe una función recursiva que imprima la suma
//de los números del 1 al n.
/*int sumaEnteros(int n)
{
    if (n == 1)
        return 1;
    else
        return sumaEnteros(n - 1) + n;
}
int n = 567;
Console.WriteLine($"La suma del 1 al {n} es:{sumaEnteros(n)}");*/

//3-Escribe una función recursiva que imprima
//la pirámide de números del 1 al n
/*class Program
{
    static void ImprimirPiramide(int n, int nivel = 1)
    {
        if (nivel <= n)
        {
            // Imprimir espacios en blanco para alinear los números
            Console.Write(new string(' ', n - nivel));

            // Imprimir números en orden ascendente
            for (int i = 1; i <= nivel; i++)
            {
                Console.Write(i + " ");
            }

            // Imprimir números en orden descendente
            for (int i = nivel - 1; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            // Nueva línea para la siguiente fila
            Console.WriteLine();

            // Llamar recursivamente para el siguiente nivel
            ImprimirPiramide(n, nivel + 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el número máximo para la pirámide: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ImprimirPiramide(n);
    }
}*/

//4-Escribe una función recursiva
//que imprima la pirámide de números invertidos del 1 al n.

/*class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el número de filas para la pirámide: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pirámide invertida de números:");

       // Loop para imprimir las filas
        for (int i = rows; i >= 1; --i)
        {
           // Imprimir espacios en blanco al principio de cada fila
            for (int space = 0; space < rows - i; ++space)
                Console.Write(" ");

            // Imprimir números en orden descendente
            for (int j = i; j >= 1; --j)
                Console.Write(j);

            // Imprimir números en orden ascendente (excepto el último número)
            for (int k = 2; k <= i; ++k)
                Console.Write(k);

            // Nueva línea para la siguiente fila
            Console.WriteLine();
        }

        Console.ReadLine(); // Para evitar que la consola se cierre inmediatamente
    }
}*/

//5_Escribe una función recursiva que imprima la tabla de multiplicar
//de un numero n ingresado por el usuario

/*Console.Write("Ingrese el número para la tabla de multiplicar: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Tabla de multiplicar del {n}");

static void imprimirTabla(int n, int multiplicador = 1)
{
    if (multiplicador <= 12)
    {
        Console.WriteLine($"{n} x {multiplicador} = {n * multiplicador}");
        imprimirTabla(n, multiplicador + 1);
    }
}
imprimirTabla(n);*/

//ARREGLOS Y MATRICES//
//6-Crea una matriz de números reales.

/*int[] numReales = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.Write("Los elementos de mí matriz son:");
foreach (int num in numReales)
{
    Console.Write(num + " ");
}*/

//7-Crea una matriz de números complejos//
// Definición de la estructura para números complejos
/*struct ComplexNumber
{
    public double RealPart { get; set; }
    public double ImaginaryPart { get; set; }

    public ComplexNumber(double realPart, double imaginaryPart)
    {
        RealPart = realPart;
        ImaginaryPart = imaginaryPart;
    }

    public override string ToString()
    {
        if (ImaginaryPart >= 0)
            return $"{RealPart} + {ImaginaryPart}i";
        else
            return $"{RealPart} - {-ImaginaryPart}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación de una matriz de números complejos
        ComplexNumber[,] complexMatrix = new ComplexNumber[2, 2];

        // Asignación de valores a la matriz
        complexMatrix[0, 0] = new ComplexNumber(1, 2);
        complexMatrix[0, 1] = new ComplexNumber(3, 4);
        complexMatrix[1, 0] = new ComplexNumber(5, 6);
        complexMatrix[1, 1] = new ComplexNumber(7, 8);

        // Imprimir la matriz
        Console.WriteLine("Matriz de números complejos:");
        for (int i = 0; i < complexMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < complexMatrix.GetLength(1); j++)
            {
                Console.Write(complexMatrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}*/

//8-Crear una matriz de matrices.//
/*class Program
{
    static void Main(string[] args)
    {
        // Crear una matriz de matrices
        int[][] matrizDeMatrices = new int[3][];
        // Inicializar cada matriz interna con diferentes tamaños
        matrizDeMatrices[0] = new int[] { 1, 2, 3 };
        matrizDeMatrices[1] = new int[] { 4, 5 };
        matrizDeMatrices[2] = new int[] { 6, 7, 8, 9 };
        // Acceder e imprimir los elementos de cada matriz interna
        for (int i = 0; i < matrizDeMatrices.Length; i++)
        {
            Console.Write($"Matriz {i + 1}: ");
            for (int j = 0; j < matrizDeMatrices[i].Length; j++)
            {
                Console.Write(matrizDeMatrices[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}*/

//9 - Accede al elemento central de una matriz//
//Para una matriz con un número impar de filas y columnas

int[,] matriz = new int[3, 3];
matriz[0, 0] = 1;
matriz[0, 1] = 2;
matriz[0, 2] = 3;
matriz[1, 0] = 2;
matriz[1, 1] = -2;
matriz[1, 2] = 2;
matriz[2, 0] = 3;
matriz[2, 1] = 2;
matriz[2, 2] = -2;

int filaCentral = matriz.GetLength(0) / 2;
int columnaCentral = matriz.GetLength(1) / 2;

int elementoCentral = matriz[filaCentral, columnaCentral];

Console.WriteLine("El elemento central de mí matriz es:" + elementoCentral);


