// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());

//Console.WriteLine($"Length of number {number.Length} simbols");

double num_0 = Math.Abs(number);
int i = 0;

while (num_0 > i)
{
    num_0 = num_0 / 10;
    i++;
}
Console.WriteLine(i);

//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28, 4 -> 10, 8 -> 36

Console.Write("Input your number: ");
int num_A = int.Parse(Console.ReadLine());

int j = 0;
int res = 0;
while (num_A > 0)
{
    res = res + num_A;
    num_A = num_A - 1;
    j++;
}
Console.WriteLine(res);