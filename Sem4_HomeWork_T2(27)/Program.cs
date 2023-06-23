// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());

int num_0 = Convert.ToInt32(Math.Abs(number));
int i = 0;
int sum = 0;

while (num_0 > 0)
{
    int num_1 = num_0 / 10;
    num_0 = num_0 % 10;
    sum = sum + num_0;
    num_0 = num_1;
    i++;
}
Console.WriteLine(sum);