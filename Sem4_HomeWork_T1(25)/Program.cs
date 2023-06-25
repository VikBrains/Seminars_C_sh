// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

Console.Write("Input your number_A: ");
double num_A = int.Parse(Console.ReadLine());

Console.Write("Input your number_B: ");
double num_B = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Pow(num_A, num_B));

