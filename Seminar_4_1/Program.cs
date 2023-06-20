// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());

// Console.WriteLine("Length of number " + number.Length + "simbols");

double num_0 = Math.Abs(number);
int i = 1;

while (num_0 > i)
{
    num_0 = num_0 / 10;
    i++;
}
Console.WriteLine(i);