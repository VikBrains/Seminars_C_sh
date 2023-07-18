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
Console.WriteLine($"Factorial number {result}");


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

//Console.Write("Input your number: ");
//int num = int.Parse(Console.ReadLine());

int[] array = new int[number];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]);
}




//Console.Write($"Factorial number {result}");