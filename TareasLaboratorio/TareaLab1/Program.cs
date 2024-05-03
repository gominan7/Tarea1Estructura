//1-OPERACIONES BASICAS//

/*double a, b, suma, resta, multiplicación, división ;
Console.Write("Ingrese un numero:");
a = double.Parse(Console.ReadLine());

Console.Write("Ingrese otro numero:");
b = double.Parse(Console.ReadLine());

suma = a + b;
resta = a - b;
multiplicación = a * b;
Console.WriteLine($"La suma es: {suma}");
Console.WriteLine($"La resta es: {resta}");
Console.WriteLine($"La multiplicación es: {multiplicación}");

if  (b != 0)
{
    división = a / b;
    Console.WriteLine($"La división es:" + Math.Round(división, 2));
}
else
{
    Console.WriteLine("La división entre cero no esta definido");
}*/

//2-VERIFICACIÓN NÚMERO PAR O IMPAR//
/*int a;
Console.Write("Ingrese un número entero positivo:");
a = int.Parse(Console.ReadLine());

if (a % 2 == 0) 
{
    Console.WriteLine($"El número {a} es PAR!");
}
else
{
    Console.WriteLine($"El número {a} es IMPAR!");
}*/

//3-AREA DE UN TRIANGULO//
/*double b, h, areaTriangulo;
Console.Write("Ingrese la base del triangulo:");
b = double.Parse(Console.ReadLine());

Console.Write("Ingrese la altura del triangulo:");
h = double.Parse(Console.ReadLine());
areaTriangulo = (b * h) / 2;
Console.WriteLine($"El Area del Triangulo es:" + Math.Round(areaTriangulo, 2));*/

//4-CALCULADORA DE FACTORIAL//
/*int n, factorial;
Console.Write("Ingrese el número de la factorial que deseé calcular:");
n= int.Parse(Console.ReadLine());
factorial = 1;

for (int i = 1; i <= n; i++)
{
    factorial *= i;
}
Console.WriteLine(factorial);*/

//5-NÚMERO PRIMO//
/*int a, contador, divisor;
Console.Write("Ingrese un número positivo:");
a = int.Parse(Console.ReadLine());
contador = 0;
divisor = 1;
while (divisor <= a)
{
    if (a % divisor == 0)
    {
        contador++;
    }
    divisor++;
}
if (contador == 2)
{
    Console.WriteLine($"El número {a} es primo");
}
else
{
    Console.WriteLine($"El número {a} no es primo");
}*/

//6-INVERSIÓN DE CADENA//
/*string cadena, cadenaInvertida;
cadena = "Jorge Luis";
cadenaInvertida = "";
for (int i = cadena.Length - 1; i >= 0; i--)
{
    cadenaInvertida += cadena[i];
}
Console.WriteLine(cadenaInvertida);*/

//7-SUMA DE NÚMEROS PARES//
/*int inicio, fin, sumPares;
Console.Write("Ingrese el rango inicial:");
inicio = int.Parse(Console.ReadLine());
Console.Write("Ingrese el rango final:");
fin = int.Parse(Console.ReadLine());
sumPares = 0;

for  (int i = inicio;  i <= fin; i++)
{
    if (i % 2 == 0)
    {
        sumPares += i;
    }
}
Console.WriteLine(sumPares);*/

//8-LISTA DE CUADRADOS//
/*List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
List<int> numerosCuadrados = new List<int>();
foreach (int numero in numeros)
{
    numerosCuadrados.Add(numero * numero);
}
Console.WriteLine("Los primeros 10 numeros cuadrados:");
foreach (int cuadrados in numerosCuadrados)
{
    Console.WriteLine(cuadrados);
}*/

//9-CONTADOR DE VOCALES//

/*string Cadena = "Hola con todos mi nombre es jorge";
int contarVocales = 0;

foreach (char c in Cadena)
{
    if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
    {
        contarVocales++;
    }
}
Console.WriteLine($"El número total de vocales en el texto '{Cadena}' es: {contarVocales}");*/

//10-NÚMEROS DE LA SERIE DE FIBONACCI//
/*int n = 10;

Console.Write($"Los primeros {n} números de Fibonacci son:");

int a = 0;
int b = 1;
Console.Write(a + "" + b + "");

for (int i = 2; i < n; i++)
{
    int temp = a + b;
    Console.Write(temp + "");
    a = b;
    b = temp;
}*/

//11-ORDENAMIENTO DE LISTA//
/*Console.Write("Ingresa una lista de números separados por espacios:");
string input = Console.ReadLine();
string[] numerosSTR = input.Split(' ');
List<int> numeros = new List<int>();

foreach (string str in numerosSTR)
{
    if (int.TryParse(str, out int num))
    {
        numeros.Add(num);
    }
    else
    {
        Console.WriteLine($"{str} no es un número válido y será ignorado.");
    }
}
for (int i = 0; i < numeros.Count - 1; i++)
{
    for (int j = i + 1; j < numeros.Count; j++)
    {
        if (numeros[i] > numeros[j])
        {
            int temp = numeros[i];
            numeros[i] = numeros[j];
            numeros[j] = temp;
        }
    }
}
Console.WriteLine("Lista oredenada de menor a mayor:");
foreach(int i in numeros)
{
    Console.Write(i + " ");
}*/

//12-PALÍNDROMO//
/*Console.Write("Ingrese la palabra que deseé saber si es Palíndrome:");
string cadena = Console.ReadLine();
string cadenaMinuscula = cadena.ToLower();
bool esPalindromo = true;

for (int i = 0, j = cadenaMinuscula.Length - 1; i < j; i++, j--)
{
    if (cadenaMinuscula[i] != cadenaMinuscula[j])
    {
        esPalindromo = false;
        break;
    }
}

if (esPalindromo)
{
    Console.WriteLine($"La palabra '{cadena}' es un palíndromo");
}
else
{
    Console.WriteLine($"La palabra '{cadena}' no es un palíndromo");
}*/

//GENERADOR DE TABLAS DE MULTIPLICAR//
/*Console.Write("Ingrese un numero para generar su tabla de multiplicar: ");
int n = int.Parse(Console.ReadLine());
int tablaMultiplicar;
for (int i = 1; i <= 11; i++)
{
     tablaMultiplicar = i * n;
    Console.WriteLine($"Tabla de multiplicar de {n} es '{i} x {n}': {tablaMultiplicar}");
}*/

//14-CALCULO DEL AREA DE UN CIRCULO//

/*double areaCirculo, radio, pi;
Console.Write("Ingrese el Radio de la circunferencia: ");
radio = double.Parse(Console.ReadLine());
pi = 3.14;
areaCirculo = pi * (radio * radio);

Console.WriteLine($"La area del ciruclo es: {Math.Round(areaCirculo, 2)}");*/

//15-SUMA DE DIGITOS//
int num = 145;
int sumaDigitos = 0;
int numeroRestante = num;

while (numeroRestante != 0)
{
    int digito = numeroRestante % 10;
    sumaDigitos += digito;
    numeroRestante /= 10;
}

Console.WriteLine($"La suma de los digitos del número {145} es: {sumaDigitos} ");
