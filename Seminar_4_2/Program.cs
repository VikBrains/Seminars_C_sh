//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.Write("Input your number: ");
int number = int.Parse(Console.ReadLine());
double a = Math.Abs(number);
double result = 1;

while (a > 0)
{
//    a = a % 10;
    result = result * a;
    a--;
}
Console.Write($"Factorial number {result}");