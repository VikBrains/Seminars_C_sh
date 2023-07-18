// Задача №22. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N

Console.Write("Input digit: ");
int a = int.Parse(Console.ReadLine());
int i = 0;

while (i <= a)
{
    Console.Write($"{i} ^ 2 = ");
    Console.WriteLine(Math.Pow(i,2));
    i = i + 1;
}