// Задача 12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.


// Console.Write("Input nimber 1: ");
// int numberA = int.Parse(Console.ReadLine());
// Console.Write("Input number 2: ");
// int numberB = int.Parse(Console.ReadLine());

// int numberC = (numberA % numberB);

// if(numberC == 0)
// {
//     Console.WriteLine("is multiple");
// }
// else
// {
//     Console.WriteLine($"is not multiple, remain is {numberC}");
// }

-------------
// Задача 14  Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Write("Input number: ");
int number = int.Parse(Console.ReadLine());

if ((number % 7) == 0 && (number % 23) == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}