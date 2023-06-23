// адача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.Write("Input your number: ");
int num = int.Parse(Console.ReadLine());

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.WriteLine($"{array[i]} ");
}
Console.WriteLine(" ");

for (int i = 0; i < array.Length; i++)
{
    if (num == array[i])
    {
        // Console.WriteLine($"{array[i]} ");
        Console.Write("There is num in array");
        // break;
    }
    else
        Console.Write("there is not num in array");
        break;
}    
