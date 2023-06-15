// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа

Console.Write("Input 3-digit integer: ");
int number = int.Parse(Console.ReadLine());

if (99 < number && number < 1000)
{
    int number_1 = number / 10;
    int number_2 = number_1 % 10;
    Console.WriteLine($"sec digit of number is: {number_2}");
}
else
{
    Console.WriteLine("Input integer is not in needed range");
}
