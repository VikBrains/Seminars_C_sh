// Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
// Пример: 44, 5, 78 -> 78

Console.WriteLine("Input first integer: ");
int num_a = int.Parse(Console.ReadLine());

Console.WriteLine("Input second integer: ");
int num_b = int.Parse(Console.ReadLine());

Console.WriteLine("Input third integer: ");
int num_c = int.Parse(Console.ReadLine());

int max = num_a;

if (num_a > max) max = num_a;
if (num_b > max) max = num_b;
if (num_c > max) max = num_c;

Console.Write("maximal integer is ");
Console.WriteLine(max);