//Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет


Console.WriteLine("Input first integer: ");
int number_1 = int.Parse(Console.ReadLine());

Console.WriteLine("Input second integer: ");
int number_2 = int.Parse(Console.ReadLine());

int number_3 = number_2 * number_2;

if (number_1 == number_3)
{
    Console.WriteLine("The first number is the square of the second number");
}
else
{
    Console.WriteLine("The first number is NOT the square of the second number");
}



// Console.WriteLine(result);