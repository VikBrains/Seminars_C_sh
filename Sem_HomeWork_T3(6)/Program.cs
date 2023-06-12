// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка).
// Пример: 4 -> да /  -3 -> нет /  7 -> нет

Console.Write("Input your integer: ");
int num = int.Parse(Console.ReadLine());

int numen = (num % 2);

if (numen == 0)
    Console.WriteLine("it is even-numbered");
else 
    Console.WriteLine("it is NOT even-numbered");
