//RECURSIVIDAD//
//1-Escrirba una función recursiva que imprima los números
//pares de 1 al 100
//class Program
//{
//    static void imprimirPares(int numero)
//    {
//        if (numero <= 100)
//        {
//            if (numero % 2 == 0)
//            {
//                Console.Write(numero + " ");
//            }
//            imprimirPares(numero + 1);
//        }
//    }

//    static void Main(string[] args)
//    {
//        imprimirPares(1);
//    }
//}

//2-Escribe una función recursiva que imprima la suma
//de los números del 1 al n.
//int sumaEnteros(int n)
//    {
//        if (n == 1) 
//            return 1;
//        else
//            return sumaEnteros(n - 1) + n;
//    }
// int n = 567;
//Console.WriteLine($"La suma del 1 al {n} es:{sumaEnteros(n)}");

//3-Escribe una función recursiva que imprima
//la pirámide de números del 1 al n
//using System;

//class Program
//{
//    static void ImprimirPiramide(int n, int nivel = 1)
//    {
//        if (nivel <= n)
//        {
//            // Imprimir espacios en blanco para alinear los números
//            Console.Write(new string(' ', n - nivel));

//            // Imprimir números en orden ascendente
//            for (int i = 1; i <= nivel; i++)
//            {
//                Console.Write(i + " ");
//            }

//            // Imprimir números en orden descendente
//            for (int i = nivel - 1; i >= 1; i--)
//            {
//                Console.Write(i + " ");
//            }

//            // Nueva línea para la siguiente fila
//            Console.WriteLine();

//            // Llamar recursivamente para el siguiente nivel
//            ImprimirPiramide(n, nivel + 1);
//        }
//    }

//    static void Main(string[] args)
//    {
//        Console.Write("Ingrese el número máximo para la pirámide: ");
//        int n = Convert.ToInt32(Console.ReadLine());
//        ImprimirPiramide(n);
//    }
//}

//4-Escribe una función recursiva
//que imprima la pirámide de números invertidos del 1 al n.

using System;
class Program
{
    static void ImprimirPiramideInvertida(int n, int nivel = 1)
    {
        if (nivel <= n)
        {
            // Imprimir espacios en blanco para alinear los números
            Console.Write(new string(' ', n - nivel));

            // Imprimir números en orden descendente
            for (int i = nivel; i >= 1; i--)
            {
                Console.Write(i + " ");
            }

            // Imprimir números en orden ascendente
            for (int i = 2; i <= nivel; i++)
            {
                Console.Write(i + " ");
            }

            // Nueva línea para la siguiente fila
            Console.WriteLine();

            // Llamar recursivamente para el siguiente nivel
            ImprimirPiramideInvertida(n, nivel + 1);
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Ingrese el número máximo para la pirámide invertida: ");
        int n = Convert.ToInt32(Console.ReadLine());
        ImprimirPiramideInvertida(n);
    }
}
