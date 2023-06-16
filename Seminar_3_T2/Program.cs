// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).



Console.WriteLine("Input Quarter number from 1 to 4: ");
int a =  int.Parse(Console.ReadLine());

switch (a)
{
    case 1: 
    Console.WriteLine("Range x>0, y>0");
    break;

    case 2:
    Console.WriteLine("Range x>0, y<0");
    break;

    case 3:
    Console.WriteLine("Range x<0, y<0");
    break;

    case 4:
    Console.WriteLine("Range x<0, y>0");
    break;

    default:Console.WriteLine("You input non-correct digit");
    break;
}