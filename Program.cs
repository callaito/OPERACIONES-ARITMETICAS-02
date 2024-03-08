// See https://aka.ms/new-console-template for more information
using operaciones2;

Console.WriteLine("OPERACIONES ARITMETICAS");
Console.WriteLine();

int valor1, valor2, resultado, resultado_ClasSuuma, resultado_ClasResta, resultado_ClasMultiplicacion, resultado_ClasDivision;

suma suma = new suma();
Console.WriteLine();
Console.Write("valor 1 :");
suma.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2 :");
suma.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_ClasSuuma = suma.operar();
Console.WriteLine($"el resultado de la suma es:  {resultado_ClasSuuma}");
Console.WriteLine();

resta resta = new resta();
Console.WriteLine();
Console.Write("valor 1 :");
resta.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2 :");
resta.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_ClasResta  = resta.operar();
Console.WriteLine($"el resultado de la resta es:  {resultado_ClasResta}");
Console.WriteLine();

multiplicacion multiplicacion = new multiplicacion();
Console.WriteLine();
Console.Write("valor 1 :");
multiplicacion.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2 :");
multiplicacion.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_ClasMultiplicacion  = multiplicacion.operar();
Console.WriteLine($"el resultado de la multiplicacion es:  {resultado_ClasMultiplicacion}");
Console.WriteLine();

division division = new division();
Console.WriteLine();
Console.Write("valor 1 :");
division.valor1 = Convert.ToInt32(Console.ReadLine());
Console.Write("valor 2 :");
division.valor2 = Convert.ToInt32(Console.ReadLine());
resultado_ClasDivision = division.operar();
Console.WriteLine($"el resultado de la division es:  {resultado_ClasDivision}");
Console.WriteLine();
