// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Пример: "5" -> 2, 4   /  "8" -> 2, 4, 6, 8

Console.Write("Input your integer: ");
int numMax = int.Parse(Console.ReadLine());
Console.WriteLine(numMax);

int num = 2;

while (num <= numMax)
{
    Console.Write(num + " ");
    num = num + 2; 
}
