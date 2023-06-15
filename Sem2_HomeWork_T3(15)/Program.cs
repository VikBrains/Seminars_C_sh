// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным. 
// 6 -> да,  7 -> да,  1 -> нет

Console.Write("Input integer from 1 to 7 incl: ");
int number = int.Parse(Console.ReadLine());

switch (number)
{
    case (1):
        Console.WriteLine("No");
        break;
    case (2):
        Console.WriteLine("No");
        break;
    case (3):
        Console.WriteLine("No");
        break;
    case (4):
        Console.WriteLine("No");
        break;
    case (5):
        Console.WriteLine("No");
        break;
    case (6):
        Console.WriteLine("Yes");
        break;
    case (7):
        Console.WriteLine("Yes");
        break;
    default:
        Console.WriteLine("you integer is not correct");
    break;
}