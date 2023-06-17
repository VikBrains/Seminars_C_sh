// Задача 23: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N:  3 -> 1, 4, 9. / 5 -> 1, 8, 27, 64, 125

Console.Write("Input digit: ");
int a = int.Parse(Console.ReadLine());
int i = 0;

while (i <= a)
{
    Console.Write($"{i} ^ 3 = ");
    Console.WriteLine(Math.Pow(i,3));
    i = i + 1;
}
